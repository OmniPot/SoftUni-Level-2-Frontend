$(document).ready(function () {
	var paintButton = $('.button-paint');

	$('.color-input').val('#00bb00');
	$('form').submit(false);

	paintButton.on('click', function paintButtonClicked (target) {
		var classSelector = $('.class-input').val(),
			color = $('.color-input').val();

		if (classSelector) {
			$('.' + classSelector).css('background', color);
		} 
	});

});