var shapesModule = shapesModule || {};

(function (shapesModule) {
	function validatePoints(points) {
		var invalidPointsCount = 'Triangle points count must be 3.';

		if (points.length !== 3) {
			throw new Error(invalidPointsCount);
		}
	}

	var triangle = shapesModule.shape.extends({
		init: function init(points, color) {
			validatePoints(points);
			this._super.init.call(this, points, color);
			return this;
		},

		draw: function draw(context) {
			context.beginPath();
			context.moveTo(this.points[0].x, this.points[0].y);

			for (var i = 0; i < this.points.length; i++) {
				context.lineTo(this.points[i].x, this.points[i].y);
			}

			context.lineTo(this.points[0].x, this.points[0].y);
			context.fillStyle = this.color;
			context.fill();
		},

		toString: function toString() {
			return this._super.toString.call(this);
		}
	});

	shapesModule.triangle = triangle;
}(shapesModule));