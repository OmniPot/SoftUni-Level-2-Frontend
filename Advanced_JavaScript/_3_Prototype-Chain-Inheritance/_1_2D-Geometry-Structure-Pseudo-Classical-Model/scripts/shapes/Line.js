var shapesModule = shapesModule || {};

(function (shapesModule) {
	function Line(points, color) {
		shapesModule.Shape.call(this, points, color);
	}

	Line.extends(shapesModule.Shape);

	Line.prototype.toString = function toString() {
		var result = shapesModule.Shape.prototype.toString.call(this) + '\n}';

		return result;
	}

	shapesModule.Line = Line;
}(shapesModule));