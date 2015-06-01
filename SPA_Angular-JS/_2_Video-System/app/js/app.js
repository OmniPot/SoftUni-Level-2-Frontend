var app = angular.module('videoSystem', ['ngRoute']);

app.config(function($routeProvider) {
	$routeProvider.when('/home', {
		controller: 'mainController',
		templateUrl: 'templates/mainView.html'
	})

	$routeProvider.otherwise({
		redirectTo: '/home'
	});
});
