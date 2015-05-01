var app = app || {};

app.eventHandlers = (function (data) {
	function headerLogoutButtonEventHandler() {
		$('#header-logout').on('click', function (event) {
			data.Users.logout()
				.then(function (result) {
				app.Router.refresh();
			});
		});
	}
	function postRevealEventHandler() {
		$('#post-reveal-button').on('click', function (event) {
			$('#post-container').slideDown('fast');
		});
	}
	function loginButtonEventHandler() {
		$('#login-button').on('click', function (event) {
			var username = $('#login-username').val().trim(),
				password = $('#login-password').val().trim();

			data.Users.login(username, password)
				.then(function (result) {
				app.Router.setLocation('#/');
				setTimeout(function () {
					$('#noty-container').noty({
						layout: 'topcenter',
						closeWith: 'hover',
						timeout: 3000,
						text: 'Successfully logged in.',
						type: 'success'
					});
				}, 500);
			});
		});
	}
	function registerButtonEventHandler() {
		$('#register-button').on('click', function (event) {
			var username = $('#reg-username').val().trim(),
				password = $('#reg-password').val().trim(),
				name = $('#reg-name').val().trim(),
				about = $('#reg-about').val().trim(),
				gender = $('.radio label input:checked').val(),
				picture = $('.picture-preview').attr('src');

			data.Users.register(username, password, name, about, gender, picture)
				.then(function (result) {
				app.Router.setLocation('#/');
				setTimeout(function () {
					$('#noty-container').noty({
						layout: 'topcenter',
						closeWith: 'hover',
						timeout: 3000,
						text: 'Successfully registered.',
						type: 'success'
					});
				}, 500);
			});
		});
	}
	function saveEditChangesButtonEventHandler() {
		$('#save-edit-changes').on('click', function (event) {
			var newData = {
				password: $('#password').val().trim(),
				name: $('#name').val().trim(),
				about: $('#about').val().trim(),
				gender: $('.radio input:checked').val(),
				picture: $('.picture-preview').attr('src')
			}

			data.Users.editProfile(newData)
				.then(function () {
				data.Users.logout()
					.then(function () {
					app.Router.setLocation('#/');
				});

			});
		});
	}
	function submitPostEventHandler() {
		$('#submit-post').on('click', function (event) {
			var content = $('#post-content').val().trim();
			data.Posts.addPost(content)
				.then(function () {
				app.Router.refresh();
			});
		});
	}
	function hoverEvents() {
		$('.post').each(function (index, post) {
			data.Users.getById($(post).find('a.profile-link').attr('data-id'))
				.then(function (result) {
				$(post).append(app.templateBuilder('hover-box', result));
			});
		});

		$('a.profile-link').bind('mousemove', function (event) {
			$(this).parents('article').last().find('div.hover-box').css({
				top: event.pageY + 5 + "px",
				left: event.pageX + 5 + "px"
			}).show();
		}).bind('mouseout', function (event) {
			$("div.hover-box").hide();
		});
	}
	function imageUploadButtonEventHandler() {
		$('#main').on('click', '#upload-file-button', function () {
			$('#picture').click();
		});

		$('#main').on('change', '#picture', function () {
			var file = this.files[0],
				reader;

			if (file.type.match(/image\/.*/)) {
				reader = new FileReader();
				reader.onload = function (e) {
					var selectedFile = $('#picture');
					var fileName = selectedFile.val().split('/').pop().split('\\').pop();

					$('.picture-preview').attr('src', e.target.result);
					$('.picture-name').text(fileName);
				};
				reader.readAsDataURL(file);
			} else {
				console.log('Type-mismatch error!');
			}
		});
	}

	return {
		headerLogoutButtonEventHandler: headerLogoutButtonEventHandler,
		postRevealEventHandler: postRevealEventHandler,
		loginButtonEventHandler: loginButtonEventHandler,
		registerButtonEventHandler: registerButtonEventHandler,
		saveEditChangesButtonEventHandler: saveEditChangesButtonEventHandler,
		submitPostEventHandler: submitPostEventHandler,
		hoverEvents: hoverEvents,
		imageUploadButtonEventHandler: imageUploadButtonEventHandler
	}
})(app.Data);