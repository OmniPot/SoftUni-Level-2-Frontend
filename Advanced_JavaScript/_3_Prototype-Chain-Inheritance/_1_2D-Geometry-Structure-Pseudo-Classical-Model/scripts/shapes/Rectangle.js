var shapesModule = shapesModule || {};

(function (shapesModule) {
	function Rectangle(topLeft, width, height, color) {
		shapesModule.Shape.call(this, topLeft, color);
		this._width = width;
		this._heigth = height;
	}

	Rectangle.extends(shapesModule.Shape);

	Rectangle.prototype.toString = function toString() {
		var result = shapesModule.Shape.prototype.toString.call(this) +
			'\n\tWidth: ' + this._width + '\n\tHeight: ' + this._heigth + '\n}';

		return result;
	}

	shapesModule.Rectangle = Rectangle;
}(shapesModule));