String.prototype.startsWith = function startsWith (subString) {
	return this.substr(0, subString.length) === subString ? true : false;
}

String.prototype.endsWith = function endsWith (subString) {
	return this.substr(this.length - subString.length, this.length) === subString ? true : false;
}

String.prototype.left = function left (count) {
	return count >= this.length ? this.toString() : this.substr(0, count);
}

String.prototype.right = function right (count) {
	return count >= this.length ? this.toString() : this.substr(this.length - count, this.length);
}

String.prototype.padLeft = function padLeft (count, character) {
	var padLength = count - this.length < 0 ? 0 : count - this.length;
	return new Array(padLength).join(character == undefined ? ' ' : character) + this;
}

String.prototype.padRight = function padRight (count, character) {
	var padLength = count - this.length < 0 ? 0 : count - this.length;
	return this + new Array(padLength).join(character == undefined ? ' ' : character);
}

String.prototype.repeat = function repeat (count) {
	return new Array(count + 1).join(this);
}

var example = "This is an example string used only for demonstration purposes.";
console.log(example.startsWith("This"));
console.log(example.startsWith("this"));
console.log(example.startsWith("other"));
console.log();

var example = "This is an example string used only for demonstration purposes.";
console.log(example.endsWith("poses."));
console.log(example.endsWith ("example"));
console.log(example.startsWith("something else"));
console.log();

var example = "This is an example string used only for demonstration purposes.";
console.log(example.left(9));
console.log(example.left(90));
console.log();

var example = "This is an example string used only for demonstration purposes.";
console.log(example.right(9));
console.log(example.right(90));
console.log();

// Combinations must also work
var example = "abcdefgh";
console.log(example.left(5).right(2));
console.log();

var hello = "hello";
console.log(hello.padLeft(5));
console.log(hello.padLeft(10));
console.log(hello.padLeft(5, "."));
console.log(hello.padLeft(10, "."));
console.log(hello.padLeft(2, "."));
console.log();

var hello = "hello";
console.log(hello.padRight(5));
console.log(hello.padRight(10));
console.log(hello.padRight(5, "."));
console.log(hello.padRight(10, "."));
console.log(hello.padRight(2, "."));
console.log();

var character = "*";
console.log(character.repeat(5));
// Alternative syntax
console.log("~".repeat(3));
// Another combination
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));
