function printArgsInfo() {
	for (var i in arguments) {
		console.log(arguments[i] + ' (' + typeof(arguments[i]) + ')');
	}

	console.log();
}

console.log('Using the "call" method of the function with arguments.');
printArgsInfo.call(this, 'Da', 9);

console.log('Using the "call" method of the function without arguments.');
printArgsInfo.call();

console.log('Using the "apply" method of the function with arguments.');
printArgsInfo.apply(this, ['Da', 9]);

console.log('Using the "apply" method of the function without arguments.');
printArgsInfo.apply();