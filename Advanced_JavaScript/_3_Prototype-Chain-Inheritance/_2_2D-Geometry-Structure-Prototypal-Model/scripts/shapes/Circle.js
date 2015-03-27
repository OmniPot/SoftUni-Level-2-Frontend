var shapesModule = shapesModule || {};

(function (shapesModule) {

	function validateRadius (radius) {
		var invalidRadiusMessage = 'Circle radius must be a positive number.';
		var noRadiusMessage = 'Circle radius is required.';

		if (radius === undefined) {
			console.error(noRadiusMessage);
		}

		if (radius <= 0 || !parseInt(radius)) {
			console.error(invalidRadiusMessage);
		}
	}

	var circle = shapesModule.shape.extends({
		init: function init(center, radius, color) {
			validateRadius(radius);
			this._super.init.call(this, center, color);
			this.radius = radius;

			return this;
		},

		draw: function draw(context) {
			context.beginPath();
			context.arc(this.points.x, this.points.y, this.radius, 0, 2 * Math.PI, false);
			context.fillStyle = this.color;
			context.fill();
		},

			toString: function toString() {
			var result = this._super.toString.call(this) + '\nRadius: ' + this.radius;
			return result;
		}
	});

	shapesModule.circle = circle;
}(shapesModule));