var shapesModule = shapesModule || {};

(function (shapesModule) {
	function Segment(points, color) {
		shapesModule.Shape.call(this, points, color);
	}

	Segment.extends(shapesModule.Shape);

	Segment.prototype.toString = function toString() {
		var result = shapesModule.Shape.prototype.toString.call(this) + '\n}';

		return result;
	}

	shapesModule.Segment = Segment;
}(shapesModule));