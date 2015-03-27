var shapesModule = shapesModule || {};

(function (shapesModule) {
	function Triangle(points, color) {
		shapesModule.Shape.call(this, points, color);
	}

	Triangle.extends(shapesModule.Shape);

	Triangle.prototype.toString = function toString() {
		var result = shapesModule.Shape.prototype.toString.call(this) + '\n}';

		return result;
	}

	shapesModule.Triangle = Triangle;
}(shapesModule));