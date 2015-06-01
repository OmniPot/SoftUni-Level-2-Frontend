app.factory('videoService', function() {
	var service = {};

	service.videos = [{
		title: 'Course introduction',
		pictureUrl: 'http://wallpapers.wallhaven.cc/wallpapers/full/wallhaven-13589.jpg',
		length: 692,
		category: 'IT',
		subscribers: 3,
		date: new Date(2014, 12, 15),
		haveSubtitles: true,
		comments: [{
			username: 'Pesho Peshev',
			content: 'Congratulations Nakov',
			date: new Date(2015, 5, 13, 23, 13, 59),
			likes: 3,
			websiteUrl: 'http://daN13140.com/'
		}]
	}, {
		title: 'Second video title',
		pictureUrl: 'http://wallpapers.wallhaven.cc/wallpapers/full/wallhaven-195045.jpg',
		length: 315,
		category: 'Sports',
		subscribers: 20,
		date: new Date(2015, 1, 16),
		haveSubtitles: false,
		comments: [{
			username: 'gosheTuuu',
			content: 'balbuk balbuk...',
			date: new Date(2015, 2, 5, 15, 20, 15),
			likes: 200,
			websiteUrl: 'http://Goshoooo.com/'
		}]
	}, {
		title: 'Third video title',
		pictureUrl: 'http://wallpapers.wallhaven.cc/wallpapers/full/wallhaven-201713.jpg',
		length: 715,
		category: 'IT',
		subscribers: 60,
		date: new Date(2015, 3, 16),
		haveSubtitles: true,
		comments: [{
			username: 'Simo',
			content: 'Доста готина мацка и кучето е сладур. ^_^',
			date: new Date(2015, 2, 5, 15, 20, 15),
			likes: 10,
			websiteUrl: 'http://nQkOiSiSaIt.com/'
		}, {
			username: 'Ednoroga',
			content: 'Dosta golqm komentar shte napisha za da vidite che moga. :P Dosta golqm komentar shte napisha za da vidite che moga.  Dosta golqm komentar shte napisha za da vidite che moga. ',
			date: new Date(2015, 2, 5, 15, 20, 15),
			likes: 10,
			websiteUrl: 'http://nQkOiSiSaIt.com/'
		}]
	}];

	return service;
});