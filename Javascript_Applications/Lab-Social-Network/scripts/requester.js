var app = app || {};

app.ApplicationID = 'iygbx2yzepES5CsvlQTy7bIXSmpfpqH7neik6a7m';
app.RestApiKey = 'RB1yjZAnwYK9gWsLYHPTgG3oJbTC5YtZPL0nSIxy';
app.baseUrl = 'https://api.parse.com/1';

app.Requester = (function () {
	function makeRequest(url, method, data, onSuccess, onError, tokenRequired) {
		var headers = {
			'X-Parse-Application-Id': 'iygbx2yzepES5CsvlQTy7bIXSmpfpqH7neik6a7m',
			'X-Parse-REST-API-Key': 'RB1yjZAnwYK9gWsLYHPTgG3oJbTC5YtZPL0nSIxy',
		}

		if (window.sessionStorage.sessionToken) {
			headers['X-Parse-Session-Token'] = window.sessionStorage.sessionToken;
		}
		
		return $.ajax({
			url: (app.baseUrl + url).toString(),
			method: method,
			type: method,
			data: data,
			success: onSuccess,
			error: onError,
			headers: headers
		});
	}

	function getRequest(url, data, onSuccess, onError) {

		return makeRequest(url, 'GET', data, onSuccess, onError);
	}

	function postRequest(url, data, onSuccess, onError) {
		return makeRequest(url, 'POST', data, onSuccess, onError);
	}

	function putRequest(url, data, onSuccess, onError) {
		return makeRequest(url, 'PUT', data, onSuccess, onError);
	}

	function deleteRequest(url, onSuccess, onError) {
		return makeRequest(url, 'DELETE', null, onSuccess, onError);
	}

	return {
		postRequest: postRequest,
		getRequest: getRequest,
		putRequest: putRequest,
		deleteRequest: deleteRequest
	};
})();