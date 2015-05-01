var app = app || {};

app.views = (function() {
	var views = {
		loadAllCountryViews: function(countries) {
			$('.country-list').html('');
			countries.forEach(function(country) {
				var $countryList = $('<ul>').addClass('country-list'),
					$countryItem = $('<li>').addClass('country-list-item'),
					$countryName = $('<p>').addClass('country-list-item-name').text(country.countryName);

				$countryItem.append($countryName);

				if ($('.country-list').length == 0) {
					$countryList.append($countryItem);
					$('.main-container').append($countryList);
				} else {
					$('.country-list').append($countryItem);
				}
			});
		},
		loadAllTownViews: function(towns) {
			$('.town-list').html('');
			towns.forEach(function(town) {
				var $townList = $('<ul>').addClass('town-list'),
					$townItem = $('<li>').addClass('town-list-item'),
					$townName = $('<p>').addClass('town-list-item-name').text(town.townName);

				$townItem.append($townName);

				if ($('.town-list').length == 0) {
					$townList.append($townItem);
					$('.towns').append($townList);
				} else {
					$('.town-list').append($townItem);
				}
			});
		}
	}

	return Object.create(views);
})();