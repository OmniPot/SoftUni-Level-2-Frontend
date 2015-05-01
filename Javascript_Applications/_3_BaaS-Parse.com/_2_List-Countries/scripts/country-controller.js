var app = app || {};

app.countryController = (function() {
	var countryController = {
		assignCountryEventHandlers: function() {
			$('.add-country-button').on('click', this.onCountryAddButtonClick);
			$('.edit-country-button').on('click', this.onCountryEditButtonClick);
			$('.remove-country-button').on('click', this.onCountryRemoveButtonClick);
		},

		selectCountry: function(countriesData) {
			$('.country-list-item').on('click', function(event) {
				var selectedCountryIndex, nameValue, $target;

				$('.country-list-item').removeClass('selected-country');

				if (event.target.tagName == 'P') {
					$target = $(event.target.parentNode);
				} else {
					$target = $(event.target);
				}

				$target.addClass('selected-country');
				selectedCountryIndex = $target.index();
				nameValue = countriesData[selectedCountryIndex].countryName;
				$('.country-field').val(nameValue);

				$.when(app.towns.getCountryTowns(countriesData[selectedCountryIndex]))
					.then(function() {
						app.loadTownViews(app.towns.data);
					});
			});
		},

		onCountryAddButtonClick: function(event) {
			var countryName = $('.country-field').val();

			if (validateCountry(countryName)) {
				app.loadCountryViews(app.countries.addCountry(countryName));
				$('.country-field').attr('placeholder', countryName + ' added.');
			} else {
				$('.country-field').attr('placeholder', 'Invalid country name.');
			}

			$('.country-field').val('');
		},

		onCountryRemoveButtonClick: function(event) {
			var index = $('.selected-country').index(),
				newData;

			if ($('.selected-country').length > 0) {
				$('.country-field').attr('placeholder', app.countries.data[index].countryName + ' removed.');
				app.loadCountryViews(app.countries.removeCountry(index, app.countries.data[index]));
				$('.selected-country').remove();
			} else {
				$('.country-field').attr('placeholder', 'No country selected');
			}

			$('.country-field').val('');
		},

		onCountryEditButtonClick: function(event) {
			var index = $('.selected-country').index(),
				country = app.countries.data[index],
				newName = $('.country-field').val();

			if ($('.selected-country').length == 0) {
				$('.country-field').attr('placeholder', 'No country selected');
			} else if (!validateCountry(newName)) {
				$('.country-field').attr('placeholder', 'Invalid country name.');
			} else {
				$('.country-field').attr('placeholder',
					app.countries.data[index].countryName + ' edited to: ' + newName);

				app.countries.data[index].countryName = newName;
				app.loadCountryViews(app.countries.editCountry(country, newName));
				$('.selected-country > p').text(newName);
			}

			$('.country-field').val('');
		}
	}

	function validateCountry(name) {
		var status = true;
		if (name.trim() == '') {
			status = false;
		}

		app.countries.data.forEach(function(c) {
			if (name.toLowerCase() == c.countryName.toLowerCase()) {
				status = false;
			}
		});

		return status;
	}

	return Object.create(countryController);
})();