var app = app || {};

app.towns = (function() {
	var headerObject = {
			'X-Parse-Application-Id': 'Agk5QDMbLDAEMJUXjfx8KToYBDAavTeXmQDZLxJ3',
			'X-Parse-REST-API-Key': 'zotcoAe7WjoJtvL4enf521TYxHNwDFT1NKc6yfhU'
		},
		GLOBAL_URL = 'https://api.parse.com/1/classes/Town/';

	var towns = {
		data: [],
		getCountryTowns: function(country) {
			var query = '?where={"country":{"__type":"Pointer","className":"Country","objectId":"' + country.objectId + '"}}';
			return $.ajax({
				method: 'get',
				headers: headerObject,
				type: 'application/json',
				url: GLOBAL_URL + query,
				success: function(data) {
					app.towns.data = data.results;
					// console.log(app.towns.data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		addCountryTown: function(country, townName) {
			var _data = {
					"townName": townName,
					"country": {
						'__type': 'Pointer',
						'className': 'Country',
						'objectId': country.objectId
					}
				},
				newTown;

			return $.ajax({
				method: 'post',
				headers: headerObject,
				url: GLOBAL_URL,
				data: JSON.stringify(_data),
				success: function(data) {
					newTown = app.models.getTown(data.objectId, _data.townName, country.objectId);
					app.towns.data.push(newTown);
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		editCountryTown: function(town, name) {
			var data = {
				'townName': name
			};

			return $.ajax({
				method: 'put',
				headers: headerObject,
				url: GLOBAL_URL + town.objectId,
				data: JSON.stringify(data),
				success: function(data) {
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		removeCountryTown: function(index, town) {
			return $.ajax({
				method: 'delete',
				headers: headerObject,
				url: GLOBAL_URL + town.objectId,

				success: function(data) {
					app.towns.data.splice(index, 1);
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		}
	}

	return Object.create(towns);
})();