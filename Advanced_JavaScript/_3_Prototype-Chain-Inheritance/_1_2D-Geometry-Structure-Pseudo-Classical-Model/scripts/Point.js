var shapesModule = shapesModule || {};

(function(shapesModule) {
	function Point(name, x, y) {
		this._name = name;
		this._x = x;
		this._y = y;
	}

	Point.prototype.toString = function toString() {
		return this._name + ':{ X: ' + this._x + ' Y: ' + this._y + ' } ';
	}

	shapesModule.Point = Point;
}(shapesModule));