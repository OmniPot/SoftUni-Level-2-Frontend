var shapesModule = shapesModule || {};

(function (shapesModule) {

	function validatePoints(points) {
		var invalidPointsCount = 'Segment points count must be 2.';

		if (points.length !== 2) {
			throw new Error(invalidPointsCount);
		}
	}

	var segment = shapesModule.shape.extends({
		init: function init(points, color) {
			validatePoints(points);
			this._super.init.call(this, points, color);

			return this;
		},

		draw: function draw (context) {
			context.beginPath();
			context.lineWidth = 6;
			context.strokeStyle = this.color;
			context.moveTo(this.points[0].x, this.points[0].y);
			context.lineTo(this.points[1].x, this.points[1].y);
			context.stroke();
		},

		toString: function toString() {
			var result = this._super.toString.call(this);

			return result;
		}
	});

	shapesModule.segment = segment;
}(shapesModule));