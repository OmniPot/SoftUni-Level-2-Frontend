var app = app || {};

app.Views = (function () {
	var HomeView = function () { },
		UserHeaderView = function () { },
		LoginView = function () { },
		RegisterView = function () { },
		EditProfileView = function () { },
		PostsView = function () { },
		HoverView = function () { };

	HomeView.prototype.render = function (homeSelector, userData) {
		$(homeSelector).html(app.templateBuilder('default-home', userData));
	}

	UserHeaderView.prototype.render = function (headerSelector, userData) {
		$(headerSelector).html(app.templateBuilder('user-header', userData));
	}

	PostsView.prototype.render = function (postsSelector, postsData) {
		$(postsSelector).html(app.templateBuilder('posts', {posts: postsData}));
	}

	LoginView.prototype.render = function (loginSelector) {
		$(loginSelector).html(app.templateBuilder('login', {}));
	};

	RegisterView.prototype.render = function (registerSelector) {
		$(registerSelector).html(app.templateBuilder('register', {}));
	};

	EditProfileView.prototype.render = function (editProfileSelector, currentData) {
		$(editProfileSelector).html(app.templateBuilder('edit-profile', currentData));
	};

	return {
		HomeView: HomeView,
		UserHeaderView: UserHeaderView,
		LoginView: LoginView,
		RegisterView: RegisterView,
		EditProfileView: EditProfileView,
		PostsView: PostsView,
		HoverView: HoverView
	};

})();