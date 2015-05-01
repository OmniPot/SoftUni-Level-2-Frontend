var app = app || {};

app.townController = (function() {
	var townController = {
		assignTownEventHandlers: function() {
			$('.add-town-button').on('click', this.onTownAddButtonClick);
			$('.edit-town-button').on('click', this.onTownEditButtonClick);
			$('.remove-town-button').on('click', this.onTownRemoveButtonClick);
		},
		selectTown: function(townsData) {
			$('.town-list-item').on('click', function(event) {
				var selectedTownIndex, nameValue, $target;

				$('.town-list-item').removeClass('selected-town');

				if (event.target.tagName == 'P') {
					$target = $(event.target.parentNode);
				} else {
					$target = $(event.target);
				}

				$target.addClass('selected-town');
				selectedTownIndex = $target.index();
				nameValue = townsData[selectedTownIndex].townName;
				$('.town-field').val(nameValue);
			});
		},
		onTownAddButtonClick: function(event) {
			var townName = $('.town-field').val(),
				index = $('.selected-country').index(),
				country = app.countries.data[index];

			if (validateTown(townName)) {
				console.log(country, townName);
				app.loadTownViews(app.towns.addCountryTown(country, townName));
				$('.town-field').attr('placeholder', townName + ' added.');
			} else {
				$('.town-field').attr('placeholder', 'Invalid town name.');
			}

			$('.town-field').val('');
		},
		onTownRemoveButtonClick: function(event) {
			var index = $('.selected-town').index(),
				newData;

			if ($('.selected-town').length > 0) {
				$('.town-field').attr('placeholder', app.towns.data[index].townName + ' removed.');
				app.towns.removeCountryTown(index, app.towns.data[index]);
				$('.selected-town').remove();


			} else {
				$('.town-field').attr('placeholder', 'No town selected');
			}

			$('.town-field').val('');
		},
		onTownEditButtonClick: function(event) {
			var index = $('.selected-town').index(),
				town = app.towns.data[index],
				newName = $('.town-field').val();

			if ($('.selected-town').length == 0) {
				$('.town-field').attr('placeholder', 'No town selected');
			} else if (!validateTown(newName)) {
				$('.town-field').attr('placeholder', 'Invalid town name.');
			} else {
				$('.town-field').attr('placeholder',
					app.towns.data[index].townName + ' edited to: ' + newName);

				app.towns.data[index].townName = newName;
				app.loadTownViews(app.towns.editCountryTown(town, newName));
				$('.selected-town > p').text(newName);
			}

			$('.town-field').val('');
		}
	}

	function validateTown(name) {
		var status = true;

		if (name.trim() == '') {
			status = false;
		}

		app.towns.data.forEach(function(c) {
			if (name.toLowerCase() == c.townName.toLowerCase()) {
				status = false;
			}
		});

		return status;
	}

	return Object.create(townController);
})();