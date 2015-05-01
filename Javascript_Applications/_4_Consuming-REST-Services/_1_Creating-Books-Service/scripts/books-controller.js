var app = app || {};

app.booksController = (function() {
	var booksController = {
		assignBooksEventHandlers: function() {
			$('.add-book-button').on('click', this.onBookAddButtonClick);
			$('.edit-book-button').on('click', this.onBookEditButtonClick);
			$('.remove-book-button').on('click', this.onBookRemoveButtonClick);
		},
		selectBook: function(booksData) {
			$('.book-list-item').on('click', function(event) {
				var selectedBookIndex, book, $target;

				$('.book-list-item').removeClass('selected-book');

				if (event.target.tagName == 'P') {
					$target = $(event.target.parentNode);
				} else {
					$target = $(event.target);
				}

				$target.addClass('selected-book');
				selectedBookIndex = $target.index();
				book = booksData[selectedBookIndex];

				$('.book-title-field').val(book.title);
				$('.book-author-field').val(book.author);
				$('.book-isbn-field').val(book.isbn);
			});
		},
		onBookAddButtonClick: function(event) {
			var bookTitle = $('.book-title-field').val(),
				bookAuthor = $('.book-author-field').val(),
				bookISBN = $('.book-isbn-field').val();

			app.loadBookViews(app.books.addBook(bookTitle, bookAuthor, bookISBN));

			$('.book-title-field').val('');
			$('.book-author-field').val('');
			$('.book-isbn-field').val('');
		},

		onBookRemoveButtonClick: function(event) {
			var index = $('.selected-book').index(),
				newData;

			if ($('.selected-book').length > 0) {
				app.books.removeBook(index, app.books.data[index])

				$('.selected-book').remove();
				$('.book-title-field').attr('placeholder', app.books.data[index].title + ' removed.').val('');
				$('.book-author-field').attr('placeholder', '').val('');
				$('.book-isbn-field').attr('placeholder', '').val('');
			}
		},

		onBookEditButtonClick: function(event) {
			var index = $('.selected-book').index(),
				book = app.books.data[index],
				newTitle = $('.book-title-field').val(),
				newAuthor = $('.book-author-field').val(),
				newISBN = $('.book-isbn-field').val();

			if ($('.selected-book').length == 0) {
				$('.book-title-field').attr('placeholder', 'No book selected.');
			} else if (newTitle == '') {
				$('.book-title-field').attr('placeholder', 'Invalid book title.');
			}else if (newAuthor == '') {
				$('.book-author-field').attr('placeholder', 'Invalid book author.');
			}else if (newISBN == '') {
				$('.book-isbn-field').attr('placeholder', 'Invalid book ISBN.');
			} else {
				$('.book-title-field').attr('placeholder',
					app.books.data[index].title + ' edited to: ' + newTitle);
				$('.book-author-field').attr('placeholder',
					app.books.data[index].author + ' edited to: ' + newAuthor);
				$('.book-isbn-field').attr('placeholder',
					app.books.data[index].isbn + ' edited to: ' + newISBN);

				app.books.data[index].title = newTitle;
				app.books.data[index].author = newAuthor;
				app.books.data[index].isbn = newISBN;

				app.loadBookViews(app.books.editBook(book, newTitle, newAuthor, newISBN));

				$('.selected-book > .book-list-item-title').text(newTitle);
				$('.selected-book > .book-list-item-author').text(newAuthor);
				$('.selected-book > .book-list-item-isbn').text(newISBN);
			}

			$('.book-title-field').val('');
			$('.book-author-field').val('');
			$('.book-isbn-field').val('');
		}
	}

	return Object.create(booksController);
})();