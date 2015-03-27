var shapesModule = shapesModule || {};

(function (shapesModule) {

	function validateColor(color) {
		var hexColorRegex = /\#([0-9abcdef]{3}){1,2}/gi,
			rgbColorRegex = /rgb(a|)\((\d{1,3})\s*\,+\s(\d{1,3})\s*\,+\s(\d{1,3})(\s*\,+\s([0-1].\d+)|)\)/gi,
			invalidColorMessage = 'Invalid shape color. Valid colors are #FFF, #ffffff, #000000, rgba(0, 0, 0, 0.5), RGB(255, 255, 255).',
			hexMatch = hexColorRegex.test(color),
			rgbColorMatch = rgbColorRegex.test(color);

		if (!hexMatch && !rgbColorMatch) {
			console.error(invalidColorMessage);
		}
	}

	var shape = {
		init: function init(points, color) {
			this.points = points;
			validateColor(color);
			this.color = color;

			return this;
		},

		toString: function toString() {
			var result = 'Points: ';
			if ((typeof this.points === "object") && (this.points !== null)) {
				result += this.points.toString();
			}

			result += '\nColor: ' + this.color;
			return result;
		}
	}

	shapesModule.shape = shape;
}(shapesModule));