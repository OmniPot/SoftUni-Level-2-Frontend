var app = app || {};

app.Router = new Sammy(function () {
	
	this.get('#/', function () {
		app.Controller.loadHome();
	});

	this.get('#/login', function () {
		app.Controller.loadLogin('#main');
	});

	this.get('#/register', function () {
		app.Controller.loadRegister('#main');
	});

	this.get('#/edit-profile', function () {
		app.Controller.loadEditProfile('#main');
	});
});

app.Router.run('#/');