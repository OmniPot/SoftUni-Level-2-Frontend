var selector = document.body;

$(selector).on('click', '#upload-file-button', function() {
	$('#picture').click();
});

$(selector).on('change', '#picture', function() {
	var file = this.files[0],
		reader;
	
	if (file.type.match(/image\/.*/)) {
		reader = new FileReader();
		reader.onload = function() {
			// TODO: set file name to picture name paragraph
			// TODO: set read image data for image preview
		};
		reader.readAsDataURL(file);
	} else {
		// TODO: Display type-mismatch error message
	}
});