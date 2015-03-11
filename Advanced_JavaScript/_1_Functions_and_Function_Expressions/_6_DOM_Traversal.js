function traverse(node) {
	var element = document.querySelector(selector);
	traverseNode(element, '');

	function traverseNode(node, spacing) {
		for (var i = 0, len = node.childNodes.length; i < len; i += 1) {
			var child = node.childNodes[i];
			var id = child.id ? ' id="' + child.id + '"' : "";
			var nodeClass = child.className ? ' class="' + child.className + '"' : "";

			if (child.nodeType === document.ELEMENT_NODE) {
				console.log(spacing + child.nodeName.toLowerCase() + ':' + id + nodeClass);
				traverseNode(child, spacing + '  ');
			}
		}
	}
}

var selector = '.birds';
traverse(selector);