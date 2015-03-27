var shapesModule = shapesModule || {};

(function (shapesModule) {
	function Circle(center, radius, color) {
		shapesModule.Shape.call(this, center, color);
		this._radius = radius;
	}

	Circle.extends(shapesModule.Shape);

	Circle.prototype.toString = function toString() {
		var result = shapesModule.Shape.prototype.toString.call(this) + '\tRadius: ' + this._radius + '\n}';
		return result;
	}

	shapesModule.Circle = Circle;
}(shapesModule));