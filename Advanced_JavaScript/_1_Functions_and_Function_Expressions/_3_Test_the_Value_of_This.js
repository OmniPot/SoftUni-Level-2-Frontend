function testContext () {
	return console.log(this);
}

function test2 () {
	testContext();
}

testContext();

new testContext();

// When 'this' is called inside a function or an object it is bound to that func/object.
// If used in the global scoper it refers that global scope.
