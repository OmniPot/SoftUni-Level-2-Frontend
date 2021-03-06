var app = app || {};

app.templateLoader = function render(tmpl_name) {
	if (!render.tmpl_cache) {
		render.tmpl_cache = {};
	}
	if (!render.tmpl_cache[tmpl_name]) {
		var tmpl_dir = 'templates';
		var tmpl_url = tmpl_dir + '/' + tmpl_name + '.html';
		var tmpl_string;
		$.ajax({
			url: tmpl_url,
			method: 'GET',
			async: false,
			success: function(data) {
				tmpl_string = data;
			}
		});

		render.tmpl_cache[tmpl_name] = Handlebars.compile(tmpl_string);
		console.log(render.tmpl_cache[tmpl_name]);
	}
	return render.tmpl_cache[tmpl_name];
}