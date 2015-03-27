(function(toDoModule) {

	function validateInput(title) {
		if (!title) {
			throw new Error('Cannot create Section with no title!');
		}
	};

	var section = {
		init: function() {
			validateInput(document.getElementById('newSectionTitle').value);
			this._html = document.createElement('section');
			this._html.className = 'clearfix';

			var _header = document.createElement('header'),
				_headerContent = document.createElement('h1'),
				_inputTitle = document.createTextNode(document.getElementById('newSectionTitle').value),
				_itemList = document.createElement('ul'),
				_sectionBody = document.createElement('div'),
				_footer = document.createElement('footer'),
				_newItemForm = document.createElement('form'),
				_newItemTitleBox = document.createElement('input'),
				_newItemButton = document.createElement('input');

			_headerContent.appendChild(_inputTitle);
			_header.appendChild(_headerContent);

			_itemList.className = 'itemList';
			_sectionBody.className = 'sectionBody';
			_newItemTitleBox.type = 'text';
			_newItemTitleBox.className = 'newItemTitle';
			_newItemButton.type = 'button';
			_newItemButton.value = '+';
			_newItemForm.className = 'newItemForm';

			_newItemButton.addEventListener('click', function() {
				var title = this.previousSibling.value;
				toDoModule.item.init(title).addToDOM(_itemList);
				this.previousSibling.value = '';
			});

			_newItemForm.appendChild(_newItemTitleBox);
			_newItemForm.appendChild(_newItemButton);
			_footer.appendChild(_newItemForm);
			
			_sectionBody.appendChild(_header);
			_sectionBody.appendChild(_itemList);

			this._html.appendChild(_sectionBody);
			this._html.appendChild(_footer);

			return this;
		},

		addToDOM: function() {
			var container = document.getElementById('container') || (function() {
				toDoModule.container.init().addToDOM();
				return document.getElementById('container');
			}());

			container.appendChild(this._html);
			document.getElementById('newSectionTitle').value = '';
		}
	}

	toDoModule.section = section;
}(toDoModule));