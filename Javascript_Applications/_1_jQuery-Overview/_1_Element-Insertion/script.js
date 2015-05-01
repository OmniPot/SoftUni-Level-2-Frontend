$(document).ready(function() {
	var $appendable, $prependable,
		$container = $('.container');

	// Prepending Element.
	$prependable = $('<h3>').text('Before with prepend()').addClass('prepended');
	$container.prepend($prependable);

	// Prepending Element To.
	$prependable = $('<h3>').text('Before with prependTo()').addClass('prepended')
	$prependable.prependTo($container);

	// Appending Element.
	$appendable = $('<h3>').text('After with append()').addClass('appended');
	$container.append($appendable);

	$appendable = $('<h3>').text('After with appendTo()').addClass('appended');
	// Appending Element To.
	$appendable.appendTo($appendable);
});