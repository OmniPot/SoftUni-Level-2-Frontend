var app = app || {};

app.bookViews = (function() {
	var view = {
		loadBookViews: function(books) {
			$('.book-list').html('');
			books.forEach(function(book) {
				var $bookList = $('<ul>').addClass('book-list'),
					$bookItem = $('<li>').addClass('book-list-item'),
					$bookTitle = $('<p>').addClass('book-list-item-title').text(book.title),
					$bookAuthor = $('<p>').addClass('book-list-item-author').text(book.author),
					$bookIsbn = $('<p>').addClass('book-list-item-isbn').text(book.isbn);

				$bookItem.append($bookTitle).append($bookAuthor).append($bookIsbn);

				if ($('.book-list').length == 0) {
					$bookList.append($bookItem);
					$('.main-container').append($bookList);
				} else {
					$('.book-list').append($bookItem);
				}
			});
		}
	}

	return Object.create(view);
})();