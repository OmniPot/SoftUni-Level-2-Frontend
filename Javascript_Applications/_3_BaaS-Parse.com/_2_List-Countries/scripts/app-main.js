var app = app || {};

$(document).ready(function() {
	var countriesArray, townsArray;
	app.loadCountryViews = function(func) {
		$.when(func).then(function() {
			countriesArray = app.countries.data;
			app.views.loadAllCountryViews(countriesArray);
			app.countryController.selectCountry(app.countries.data);
		});
	}

	app.loadTownViews = function(func) {
		$.when(func).then(function() {
			townsArray = app.towns.data;
			app.views.loadAllTownViews(townsArray);
			app.townController.selectTown(app.towns.data);
		});
	}

	app.countryController.assignCountryEventHandlers();
	app.townController.assignTownEventHandlers();

	app.loadCountryViews(app.countries.getAllCountriesData());

});