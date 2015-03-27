var shapesModule = shapesModule || {};

(function (shapesModule) {
	function Shape(points, color) {
		this._points = points;
		this._color = color;
	}

	Shape.prototype.toString = function toString() {
		var result = Object.getPrototypeOf(this).constructor.name + ' {\n\tPoints: ';
		if (Array.isArray(this._points)) {
			for (var p in this._points) {
				result += '\n\t\t' + this._points[p].toString();
			}
		} else {
			result += this._points.toString();
		}

		result += '\n\tColor: ' + this._color;
		return result;
	}

	shapesModule.Shape = Shape;
}(shapesModule));