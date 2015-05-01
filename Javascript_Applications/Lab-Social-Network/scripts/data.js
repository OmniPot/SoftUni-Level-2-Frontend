var app = app || {};

app.Data = (function (requester) {
	var Users = {
		login: function (username, password) {
			return requester.getRequest('/login', {
				username: username,
				password: password
			}, function (result) {
					sessionStorage['sessionToken'] = result.sessionToken;
					sessionStorage['userId'] = result.objectId;
					return result;
				}, function (error) {
					console.log(error);
				});
		},
		register: function (username, password, name, about, gender, picture) {
			var dataToSend = {
				username: username,
				password: password,
				name: name,
				about: about,
				gender: gender,
				picture: picture
			};

			return requester.postRequest('/users/', JSON.stringify(dataToSend),
				function (result) {
					console.log(result);
				},
				function (error) {
					console.log(error);
				});
		},
		editProfile: function (newProfileData) {
			var userId = window.sessionStorage.userId;

			return requester.putRequest('/users/' + userId, JSON.stringify(newProfileData),
				function (result) {
					return result;
				},
				function (error) {
					console.log(error);
				});
		},
		getById: function (id) {
			return requester.getRequest('/users/' + id, null,
				function (result) {
					return result;
				},
				function (error) {
					console.log(error);
				});
		},
		getCurrentUserData: function () {
			if (sessionStorage.sessionToken && window.sessionStorage.userId) {
				return {
					sessionToken: window.sessionStorage.sessionToken,
					userId: window.sessionStorage.userId
				};
			}
			return null;
		},
		logout: function () {
			return requester.postRequest('/logout', null,
				function (result) {
					window.sessionStorage.clear();
				},
				function (error) {
					console.log(error);
				});
		}
	};

	var Posts = {
		getAllPosts: function () {
			return requester.getRequest('/classes/Post?include=createdBy', null,
				function (result) {
					return result;
				},
				function (error) {
					console.log(error);
				});
		},
		getById: function (postId) {
			return requester.getRequest('/classes/Post?include=createdBy' + postId, null,
				function (result) {
					return result;
				},
				function (error) {
					console.log(error);
				});
		},
		addPost: function (content) {
			var postData = {
				"content": content,
				"createdBy": {
					"__type": "Pointer",
					"className": "_User",
					"objectId": window.sessionStorage.userId
				}
			};

			return requester.postRequest('/classes/Post', JSON.stringify(postData),
				function (result) {
					console.log(result);
					return result;
				},
				function (error) {
					console.log(error);
				});
		}
	};

	return {
		Users: Users,
		Posts: Posts
	};
} (app.Requester));