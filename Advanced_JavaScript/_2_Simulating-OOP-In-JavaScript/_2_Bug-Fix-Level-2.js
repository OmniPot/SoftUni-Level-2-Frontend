var Person = function(fName, lName) {
	Object.defineProperty(this, 'firstName', {
		set: function(fName) {
			this._firstName = fName;
		},

		get: function() {
			return this._firstName;
		}
	});

	Object.defineProperty(this, 'lastName', {
		set: function(lName) {
			this._lastName = lName;
		},

		get: function() {
			return this._lastName;
		}
	});

	Object.defineProperty(this, 'fullName', {
		set: function (fullName) {
			this._firstName = fullName.substr(0, fullName.indexOf(' '));
			this.lastName = fullName.substr(fullName.indexOf(' ') + 1, fullName.length);
		},

		get: function() {
			return this._firstName + ' ' + this._lastName;
		}
	});

	this.firstName = fName;
	this.lastName = lName;
};

var person = new Person("Peter", "Jackson");

// Changing values
person.firstName = "Michael";
console.log(person.firstName);
console.log(person.fullName);
person.lastName = "Williams";
console.log(person.lastName);
console.log(person.fullName);

console.log();

person.fullName = "Alan Marcus";
console.log(person.fullName);
console.log(person.firstName);
console.log(person.lastName);
