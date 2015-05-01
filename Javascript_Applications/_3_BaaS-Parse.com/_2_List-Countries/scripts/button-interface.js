(function() {
	var $addButton = $('<button>').addClass('button add-country-button').text('Add Country'),
		$editButton = $('<button>').addClass('button edit-country-button').text('Edit Country'),
		$deleteButton = $('<button>').addClass('button remove-country-button').text('Remove Country');

	$('.buttons').first().append($addButton).append($editButton).append($deleteButton);

	$addButton = $('<button>').addClass('button add-town-button').text('Add Town'),
	$editButton = $('<button>').addClass('button edit-town-button').text('Edit Town'),
	$deleteButton = $('<button>').addClass('button remove-town-button').text('Remove Town');

	$('.towns-buttons').append($addButton).append($editButton).append($deleteButton);
})();