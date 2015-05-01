var books =
[{"book":"The Grapes of Wrath","author":"John Steinbeck","price":"34,24","language":"French"},
{"book":"The Great Gatsby","author":"F. Scott Fitzgerald","price":"39,26","language":"English"},
{"book":"Nineteen Eighty-Four","author":"George Orwell","price":"15,39","language":"English"},
{"book":"Ulysses","author":"James Joyce","price":"23,26","language":"German"},
{"book":"Lolita","author":"Vladimir Nabokov","price":"14,19","language":"German"},
{"book":"Catch-22","author":"Joseph Heller","price":"47,89","language":"German"},
{"book":"The Catcher in the Rye","author":"J. D. Salinger","price":"25,16","language":"English"},
{"book":"Beloved","author":"Toni Morrison","price":"48,61","language":"French"},
{"book":"Of Mice and Men","author":"John Steinbeck","price":"29,81","language":"Bulgarian"},
{"book":"Animal Farm","author":"George Orwell","price":"38,42","language":"English"},
{"book":"Finnegans Wake","author":"James Joyce","price":"29,59","language":"English"},
{"book":"The Grapes of Wrath","author":"John Steinbeck","price":"42,94","language":"English"}];

var groupAndSort = [];
_.forEach(_.groupBy(books, 'language'), function (key) {
	key = _.sortByAll(key, ['author', 'price']);
	groupAndSort.push(key);
});
console.log(groupAndSort);

var averagePrices = {};
_.forEach(_.groupBy(books, 'author'), function (books) {
	averagePrices[books[0].author] = _.reduce(_.pluck(books, 'price'), function (result, n) {
		return parseFloat(result) + parseFloat(n);
	});
});
console.log(averagePrices);

var filtereBooks = _.groupBy(_.filter(books, function (book) {
	return (book.language == "Bulgarian" || book.language == "German") && parseFloat(book.price) < 30;
}), 'author');
console.log(filtereBooks);