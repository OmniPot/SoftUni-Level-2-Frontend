Object.prototype.extends = function (properties) {
  	function func() {};
	var prop;
    func.prototype = Object.create(this);
    for (prop in properties) {
        func.prototype[prop] = properties[prop];
	};

	func.prototype._super = this;
	return new func();
}