var app = app || {};

app.books = (function() {
	var headerObject = {
			'X-Parse-Application-Id': 'dg6dl7HtV6fxoM4gZmVD8IAkT43sMY7c1XX5EuUo',
			'X-Parse-REST-API-Key': 'pwUQRaf0trjnJLpLzKUsgP35s722bBf7x1Xq69EL'
		},
		GLOBAL_URL = 'https://api.parse.com/1/classes/Book/';

	var books = {
		data: [],
		getAllBooks: function() {
			return $.ajax({
				method: 'get',
				headers: headerObject,
				url: GLOBAL_URL,
				success: function(books) {
					app.books.data = books.results;
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		addBook: function(title, author, isbn) {
			var _data = {
					"title": title,
					"author": author,
					"isbn": isbn
				},
				newBook;

			return $.ajax({
				method: 'post',
				headers: headerObject,
				url: GLOBAL_URL,
				data: JSON.stringify(_data),
				success: function(data) {
					newBook = {
						'objectId': data.objectId,
						"title": _data.title,
						"author": _data.author,
						"isbn": _data.isbn
					};
					app.books.data.push(newBook);
					// console.log(data)
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		removeBook: function(index, book) {
			return $.ajax({
				method: 'delete',
				headers: headerObject,
				url: GLOBAL_URL + book.objectId,
				success: function(data) {
					app.books.data.splice(index, 1);
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		},
		editBook: function(book, title, author, isbn) {
			var _data = {
				'objectId': book.objectId,
				"title": title,
				"author": author,
				"isbn": isbn
			};

			return $.ajax({
				method: 'put',
				headers: headerObject,
				url: GLOBAL_URL + book.objectId,
				data: JSON.stringify(_data),
				success: function(data) {
					// console.log(data);
				},
				error: function(err) {
					console.log(err);
				}
			});
		}
	}

	return Object.create(books);
})();