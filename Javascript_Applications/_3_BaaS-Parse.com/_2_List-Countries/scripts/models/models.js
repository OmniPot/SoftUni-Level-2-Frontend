var app = app || {};

app.models = (function() {
	var models = {
		getCountry: function(id, name) {
			return Object.create(country).init(id, name);
		},
		getTown: function(id, name, country) {
			return Object.create(town).init(id, name, country);
		}
	}

	var country = {
		init: function(id, name) {
			this.objectId = id;
			this.countryName = name;

			return this;
		}
	}

	var town = {
		init: function(id, name, country) {
			this.objectId = id;
			this.townName = name;
			this.country = country;

			return this;
		}
	}

	return Object.create(models);

})();