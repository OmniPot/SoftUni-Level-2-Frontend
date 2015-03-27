var shapesModule = shapesModule || {};

(function (shapesModule) {

	function validatePointCoordinates(x, y) {
		var requiredXAndY = 'X and Y coordinates of a point are required.';
		
		if (x === undefined || y === undefined) {
			throw new Error(requiredXAndY);
		}
	}

	var point = {
		init: function init(name, x, y) {
			this.name = name;
			validatePointCoordinates(x, y);
			this.x = x;
			this.y = y;

			return this;
		},

		toString: function toString() {
			return this.name + ': { X: ' + this.x + ' Y: ' + this.y + ' } ';
		}
	}

	shapesModule.point = point;
}(shapesModule));