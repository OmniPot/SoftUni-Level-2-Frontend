var domModule = (function() {
	return {
		appendChild: function(element, selector) {
			var parent = document.querySelector(selector);
			parent.appendChild(element);
		},

		removeChild: function(parent, selector) {
			var parentElement = document.querySelector(parent);
			parentElement.removeChild(parentElement.querySelector(selector));
		},

		addHandler: function(selector, event, handler) {
			var elements = Array.prototype.slice.call(document.querySelectorAll(selector));
			for (var i = 0; i < elements.length; i++) {
				elements[i].addEventListener(event, handler, false);
			}
		},

		retrieveElements: function (selector) {
			return document.querySelectorAll(selector);
		}
	}
})();

var liElement = document.createElement("li");

// Appends a list item to ul.birds-list
domModule.appendChild(liElement, ".birds-list");

// Removes the first li child from the bird list
domModule.removeChild("ul.birds-list", "li:first-child");

// Adds a click event to all bird list items
domModule.addHandler("li.bird", 'click', function() {
	alert("I'm a bird!")
});

// Retrives all elements of class "bird"
var elements = domModule.retrieveElements(".bird");
console.log(elements);
