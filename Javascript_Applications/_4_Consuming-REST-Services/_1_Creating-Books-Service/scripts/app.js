var app = app || {};

$(document).ready(function() {
	var booksData;

	app.loadBookViews = function(func) {
		$.when(func).then(function() {
			booksData = app.books.data;
			app.bookViews.loadBookViews(booksData);
			app.booksController.selectBook(app.books.data);
		});
	}

	app.booksController.assignBooksEventHandlers();
	app.loadBookViews(app.books.getAllBooks());

});