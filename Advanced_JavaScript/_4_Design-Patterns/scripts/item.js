var toDoModule = toDoModule || {};

(function(toDoModule) {

	function validateInput(title) {
		if (!title) {
			throw new Error('Cannot create Item with no content!');
		}
	};

	var item = {
		init: function(title, parent) {
			validateInput(title);
			this._html = document.createElement('li');
			this._html.className = 'item';

			var _itemCheckBox = document.createElement('input'),
				_itemTitle = document.createElement('div'),
				_titleSpan = document.createElement('p');

			_itemCheckBox.type = 'checkbox';
			_itemCheckBox.className = 'itemCheckBox';

			_itemCheckBox.addEventListener('change', function() {
				if (this.checked) {
					this.parentNode.style.background = '#458B00';
				}else{
					this.parentNode.style.background = '#eee';
				}
			});

			_titleSpan.appendChild(document.createTextNode(title))
			_itemTitle.className = 'itemTitle';
			_itemTitle.appendChild(_titleSpan);

			this._html.appendChild(_itemCheckBox);
			this._html.appendChild(_itemTitle);

			return this;
		},

		addToDOM: function(parent) {
			parent.appendChild(this._html);
		}
	};

	toDoModule.item = item;
}(toDoModule));