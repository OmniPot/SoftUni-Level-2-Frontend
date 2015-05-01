var app = app || {};

(function() {
	app.Router = new Sammy(function() {
		this.get('#/Toshko', function() {
			$('.greeting').html('<h2>Hello, I\'m Toshko.</h2>');
		});

		this.get('#/Rumen', function() {
			$('.greeting').html('<h2>Hello, I\'m Rumen.</h2>');
		});

		this.get('#/Martin', function() {
			$('.greeting').html('<h2>Hello, I\'m Martin.</h2>');
		});

		this.get('#/Goshko', function() {
			$('.greeting').html('<h2>Hello, I\'m Goshko.</h2>');
		});

		this.get('', function() {
			$('.greeting').html('<h2>Click on a name!</h2>');
		})
	});

	app.Router.run('#/');
})();