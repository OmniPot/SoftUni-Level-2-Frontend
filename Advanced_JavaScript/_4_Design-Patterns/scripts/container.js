var toDoModule = toDoModule || {};

(function(toDoModule) {

	var newSectionButton = document.getElementById('newSectionButton');
	newSectionButton.onclick = function() {
		toDoModule.section.init().addToDOM();
	}

	var container = {
		init: function() {
			this._html = document.createElement('article');
			this._html.className = 'container';
			this._html.id = 'container';

			return this;
		},

		addToDOM: function() {
			var referencedElement = document.getElementById('newSectionForm'),
				parentElement = referencedElement.parentNode;

			parentElement.insertBefore(this.init()._html, referencedElement);
		}
	}



	toDoModule.container = container;

}(toDoModule));