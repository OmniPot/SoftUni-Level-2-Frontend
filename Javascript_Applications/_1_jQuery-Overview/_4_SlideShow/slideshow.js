$(document).ready(function() {
	var slideShowGap = 3000,
		animationInterval = 600,
		eventDelay = 1100;

	$('.control').on('click', assignClasses);

	var interval = setInterval(assignClasses, slideShowGap);

	function assignClasses() {
		console.log($('').switchClass)
		$('.control').off('click', assignClasses);

		var $currItem = $('.current'),
			$prevItem = getPrev($currItem),
			$nextItem = getNext($currItem),
			$leftControl = $('.left-control')[0],
			$rightControl = $('.right-control')[0];

		if ($(this)[0] == $leftControl) {
			$currItem.switchClass('current', 'right', animationInterval, 'easeInOutQuad');
			$prevItem.addClass('left');
			$prevItem.switchClass('left', 'current', animationInterval - 1, 'easeInOutQuad');
			clearInterval(interval);
		} else if ($(this)[0] == $rightControl) {
			$currItem.switchClass('current', 'left', animationInterval, 'easeInOutQuad');
			$nextItem.addClass('right');
			$nextItem.switchClass('right', 'current', animationInterval - 1, 'easeInOutQuad');
			clearInterval(interval);
		} else {
			$currItem.switchClass('current', 'left', animationInterval, 'easeInOutQuad');
			$nextItem.addClass('right');
			$nextItem.switchClass('right', 'current', animationInterval - 1, 'easeInOutQuad');
		}

		setTimeout(function() {
			$currItem.removeClass('right');
			$currItem.removeClass('left');
			$prevItem.removeClass('right');
			$prevItem.removeClass('left');
			$nextItem.removeClass('right');
			$nextItem.removeClass('left');
		}, animationInterval);

		setTimeout(function() {
			$('.control').on('click', assignClasses);
		}, eventDelay);
	}

	function getNext(current) {
		var $next = current.next();
		if ($next.text() === '') {
			$next = $('.slide').first();
		}

		return $next;
	}

	function getPrev(current) {
		var $prev = current.prev();
		if ($prev.text() === '') {
			$prev = $('.slide').last();
		}

		return $prev;
	}

});