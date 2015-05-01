define('item', function() {
    return (function () {
        var itemIdCounter = 1;

        var Item = {
            constructor: function (content) {
                this.content = content;
                this.element = this._addToDOM();
                return this;
            },
            _addToDOM: function () {
                var element = document.createElement("div");
                var checkbox = document.createElement('input');
                checkbox.type = "checkbox";
                checkbox.name = this.content;
                checkbox.id = "item " + itemIdCounter;

                checkbox.onclick = function () {
                    if (checkbox.checked) {
                        element.style.background = "darkgreen";
                        element.style.color = 'white';
                    } else {
                        element.style.background = "transparent";
                        element.style.color = 'black';
                    }
                };

                var label = document.createElement('label');
                label.htmlFor = "item " + itemIdCounter;
                label.appendChild(document.createTextNode(this.content));

                itemIdCounter++;

                label.style.borderBottom = "1px solid black";
                label.style.padding = "3px";

                element.style.margin = "6px";
                element.style.padding = "3px";

                element.appendChild(checkbox);
                element.appendChild(label);
                return element;
            }
        }

        return Item;
    })();
});