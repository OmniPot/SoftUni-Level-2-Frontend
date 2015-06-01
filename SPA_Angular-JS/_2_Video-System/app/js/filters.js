app.filter('categoryFilter', function() {
	return function(videos, category) {
		var filtered = videos;
		if (category) {
			filtered = videos.filter(function(video) {
				return video.category.toLowerCase().indexOf(category.toLowerCase()) >= 0;
			});
		}

		return filtered;
	};
});

app.filter('dateFilter', function() {
	return function(videos, date) {
		var filtered = videos;
		if (date) {
			date = date.toDateString();
			filtered = videos.filter(function(video) {
				return video.date.indexOf(date) >= 0;
			});
		}

		return filtered;
	};
});

app.filter('subtitleFilter', function() {
	return function(videos, haveSubtitles) {
		var filtered = videos;
		if (haveSubtitles) {
			filtered = videos.filter(function(video) {
				return video.haveSubtitles == haveSubtitles;
			});
		}

		return filtered;
	};
});