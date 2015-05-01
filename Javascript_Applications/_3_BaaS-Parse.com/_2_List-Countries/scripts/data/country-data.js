var app = app || {};

app.countries = (function() {
	var headerObject = {
			'X-Parse-Application-Id': 'Agk5QDMbLDAEMJUXjfx8KToYBDAavTeXmQDZLxJ3',
			'X-Parse-REST-API-Key': 'zotcoAe7WjoJtvL4enf521TYxHNwDFT1NKc6yfhU'
		},
		GLOBAL_URL = 'https://api.parse.com/1/classes/Country/';

	var countries = {
		data: [],
		getAllCountriesData: function() {
			return $.ajax({
				method: 'get',
				headers: headerObject,
				url: GLOBAL_URL,
				success: function(data) {
					app.countries.data = data.results;
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		addCountry: function(countryName) {
			var _data = {
					"countryName": countryName
				},
				newCountry;

			return $.ajax({
				method: 'post',
				headers: headerObject,
				url: GLOBAL_URL,
				data: JSON.stringify(_data),
				success: function(data) {
					newCountry = app.models.getCountry(data.objectId, _data.countryName);
					app.countries.data.push(newCountry);
					// console.log(data)
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		editCountry: function(country, name) {
			var data = {
				'countryName': name
			};

			return $.ajax({
				method: 'put',
				headers: headerObject,
				url: GLOBAL_URL + country.objectId,
				data: JSON.stringify(data),
				success: function(data) {
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		removeCountry: function(index, country) {
			return $.ajax({
				method: 'delete',
				headers: headerObject,
				url: GLOBAL_URL + country.objectId,
				success: function (data) {
					app.countries.data.splice(index, 1);
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		}
	}

	return Object.create(countries);
})();