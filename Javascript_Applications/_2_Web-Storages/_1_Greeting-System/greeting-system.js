(function() {
	$(document).ready(function() {

		var $container = $('<main id>').attr('id', 'container').addClass('container').prependTo('body');

		if (!localStorage.username) {
			loadLoginForm();
		} else {
			loadGreetMessage(localStorage.username);
		}
	});

	function loadLoginForm() {
		var $form = $('<form>').attr('id', 'login-form').addClass('login-form'),
			$loginUsername = $('<input>').attr('type', 'text').addClass('login-username'),
			$loginButton = $('<button>').text('Login').addClass('login-button');

		$loginButton[0].addEventListener('click', function() {
			localStorage.username = $loginUsername.val();
			$form.remove();
			loadGreetMessage($loginUsername.val());
		});

		$form.append($loginUsername);
		$form.append($loginButton);
		$('.container').append($form);
		$('body').prepend($('.container'));
	}

	function loadGreetMessage(username) {
		var $message = $('<h2>').text('Welcome back, ' + username + '!').addClass('greeting-message');
			$logoutButton = $('<button>').text('Logout').addClass('logout-button');

		$logoutButton[0].addEventListener('click', function () {
			localStorage.removeItem('username');
			$message.remove();
			$logoutButton.remove();
			loadLoginForm();
		});

		$('.container').append($message).append($logoutButton);
	}
})();