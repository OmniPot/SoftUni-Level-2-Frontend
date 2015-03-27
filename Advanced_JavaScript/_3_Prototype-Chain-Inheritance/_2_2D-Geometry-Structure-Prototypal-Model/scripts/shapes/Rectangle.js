var shapesModule = shapesModule || {};

(function (shapesModule) {

	var rectangle = shapesModule.shape.extends({
		init: function init(topLeft, width, height, color) {
			this._super.init.call(this, topLeft, color);
			this.width = width;
			this.height = height;

			return this;
		},

		draw: function draw(context) {
			context.fillStyle = this.color;
			context.fillRect(this.points.x, this.points.y, this.width, this.height);
		},

		toString: function toString() {
			var result = this._super.toString.call(this) +
				'\nWidth: ' + this.width + '\nHeight: ' + this.height;

			return result;
		}
	});

	shapesModule.rectangle = rectangle;
}(shapesModule));