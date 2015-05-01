(function() {
	localStorage.correctAnswers = '{".question.q1":".answer.a1",".question.q2":".answer.a2",".question.q3":".answer.a3",".question.q4":".answer.a4"}';

	$(document).ready(function() {
		var pollTime = localStorage.pollTime || 60 * 2,
			display = $('.timer'),
			time;

		$('#poll-form').submit(false);

		time = startTimer(pollTime, display);
		loadAnswers();
		onClickSaveToStorage();
		onSubmitDisplayAnswers(time, display);
	});

	function startTimer(duration, display) {
		var timer = duration,
			minutes, seconds;

		var interval = setInterval(function() {
			minutes = parseInt(timer / 60, 10);
			seconds = parseInt(timer % 60, 10);

			minutes = minutes < 10 ? "0" + minutes : minutes;
			seconds = seconds < 10 ? "0" + seconds : seconds;

			display.text(minutes + ":" + seconds);
			localStorage.pollTime = timer;

			if (--timer < 0) {
				clearInterval(interval);
				$('.submit-button').remove();
				display.text("Time's up!");
				localStorage.removeItem('pollTime');
			}
		}, 1000);

		return interval;
	}

	function loadAnswers() {
		var questions = $('.question');
		questions.each(function(q) {
			var qSelector = '.' + questions[q].className.replace(' ', '.'),
				markedAnswer = localStorage[qSelector];

			$(qSelector + ' ' + markedAnswer + ' input').prop('checked', 'true');
		});
	}

	function onClickSaveToStorage() {
		$('.question').click(function(event) {
			if (event.target.tagName == 'INPUT') {
				var parent = $(event.target.parentNode.parentNode),
					answer = $(event.target.parentNode);

				parent.children().css('background', 'none');
				answer.css('background', '#ccc');

				localStorage['.' + parent[0].className.replace(' ', '.')] =
					'.' + answer[0].className.replace(' ', '.');
			}
		});
	}

	function onSubmitDisplayAnswers(timer, display) {
		$('.submit-button').click(function(event) {
			var correct = JSON.parse(localStorage.correctAnswers);
			for (var key in correct) {
				$(key + ' ' + correct[key]).css('background', 'rgb(0, 200, 0)');
			}

			clearInterval(timer);
			$('.submit-button').remove();
			display.text("Succesfully submitted!\n" + display.text());
			localStorage.clear();
		});
	}

})();