$(document).ready(function tableGenerator() {
	var $tHead, $tRow, $tCell,
		json = "[{\"manufacturer\":\"BMW\",\"model\":\"E92 320i\",\"year\":2011,\"price\":50000,\"class\":\"Family\"},{\"manufacturer\":\"Porsche\",\"model\":\"Panamera\",\"year\":2012,\"price\":100000,\"class\":\"Sport\"},{\"manufacturer\":\"Peugeot\",\"model\":\"305\",\"year\":1978,\"price\":1000,\"class\":\"Family\"}]",
		parsedJSON = $.parseJSON(json),
		table = $('<table>').append('<thead>').append('<tbody>').addClass('main-table');

	$('body').append(table);
	$('thead').append($('<tr>'));

	Object.keys(parsedJSON['0']).forEach(function(key) {
		$tHead = $('<th>').text(key);
		$('thead > tr').append($tHead);
	});

	parsedJSON.forEach(function(object) {
		$tRow = $('<tr>');

		Object.keys(object).forEach(function(key) {
			$tCell = $('<td>').text(object[key]);
			$tRow.append($tCell);
		});

		$('tbody').append($tRow);
	});
});