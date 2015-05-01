var app = app || {};

(function() {
	var people = {
		data: [{
			name: 'Ludiq Ludak',
			jobTitle: 'Kojar',
			website: 'http://zakojite.com'
		}, {
			name: 'Silen Sam',
			jobTitle: 'Znahar',
			website: 'http://znaharstvoiiliuminati.com'
		}, {
			name: 'Iskam Oshte',
			jobTitle: 'Cirkadjiq',
			website: 'http://happyhour.com'
		}]
	}

	console.log(people);
	var parsedHtml = app.templateLoader('table-template')(people);
	console.log(parsedHtml);
	$('.container').html(parsedHtml);
})();