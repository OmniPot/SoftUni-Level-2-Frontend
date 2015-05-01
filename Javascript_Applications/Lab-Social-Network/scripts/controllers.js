var app = app || {};

app.Controller = (function (data, views, handlers) {
	var controller = {
		loadHome: function () {
			var userData = data.Users.getCurrentUserData();
			if (!userData) {
				var homeView = new views.HomeView();
				$('#header').html('');
				homeView.render("#main");
			} else {
				data.Users.getById(userData.userId)
					.then(function (result) {
					app.Controller.loadHeader(result);
					app.Controller.loadPosts(result);

					handlers.headerLogoutButtonEventHandler();
					handlers.postRevealEventHandler();
				});
			}
		},
		loadHeader: function (userData) {
			var headerView = new views.UserHeaderView();
			headerView.render("#header", userData);
		},
		loadLogin: function () {
			var loginView = new views.LoginView();
			loginView.render("#main");

			handlers.loginButtonEventHandler();
		},
		loadRegister: function () {
			var registerView = new views.RegisterView();
			registerView.render("#main");

			handlers.registerButtonEventHandler();
			handlers.imageUploadButtonEventHandler();
		},
		loadEditProfile: function () {
			var userData = data.Users.getCurrentUserData();
			if (!userData) {
				app.Router.setLocation('#/');
			} else {
				data.Users.getById(window.sessionStorage.userId)
					.then(function (result) {
					var currentData = {
						username: result.username,
						name: result.name,
						about: result.about,
						gender: result.gender,
						picture: result.picture
					}
					
					var headerView = new views.UserHeaderView();
					headerView.render('#header', result);
					
					var editProfileView = new views.EditProfileView();
					editProfileView.render('#main', currentData);

					handlers.saveEditChangesButtonEventHandler();
					handlers.imageUploadButtonEventHandler();
				}, function (error) {
						console.log(error.responseText);
						app.Router.setLocation('#/');
					});
			}
		},
		loadPosts: function (userData) {
			data.Posts.getAllPosts()
				.then(function (postData) {
				var postsView = new views.PostsView();
				postsView.render('#main', postData.results);

				handlers.submitPostEventHandler();
				handlers.hoverEvents();
			});
		}
	};

	return controller;
})(app.Data, app.Views, app.eventHandlers);