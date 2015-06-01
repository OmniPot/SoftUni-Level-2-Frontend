app.controller('mainController', function($scope, videoService) {
	$scope.data = videoService;
	$scope.filterObject = {
		category: '',
		date: '',
		haveSubtitles: undefined,
	};

	$scope.orderObject = { selectedOrder: '' };
	$scope.orderByOptions = [
		{ value: 'category' }, 
		{ value: 'subscribers' }, 
		{ value: 'length' }, 
		{ value: 'date' }];

	$scope.newVideo = {};

	$scope.addVideo = function() {
		console.log($scope);
		$scope.data.videos.push({
			title: $scope.newVideo.title,
			pictureUrl: $scope.newVideo.url,
			length: 0,
			category: $scope.newVideo.category,
			subscribers: 0,
			date: new Date(),
			haveSubtitles: false,
			comments: []
		});

		$scope.newVideo.title = '';
		$scope.newVideo.url = '';
		$scope.newVideo.category = '';
	};

	$scope.formatVideoLength = function (length) {
		var minutes = (length / 60).toFixed(0);
		var seconds = (length % 60) >= 10 ? length % 60 : length % 60 + '0';
		return minutes + ':' + seconds;
	}

	$scope.formatVideoDate = function (date) {
		return date.toDateString();
	}
});