var shapesModule = shapesModule || {};

var circle = new shapesModule.Circle(new shapesModule.Point('O', 4, 5), 2, '#FF0000');
console.log(circle.toString());

var rectangleTopLeftPoint = new shapesModule.Point('A', 20, 20)
var rectangle = new shapesModule.Rectangle(rectangleTopLeftPoint, 100, 100, '#0000FF');
console.log(rectangle.toString());

var trianglePoints = [
	new shapesModule.Point('A', 2, 2),
	new shapesModule.Point('B', 4, 4),
	new shapesModule.Point('C', 1, 3)
];
var triangle = new shapesModule.Triangle(trianglePoints, '#00FF00');
console.log(triangle.toString());

var linePoints = [
	new shapesModule.Point('A', 6, 1),
	new shapesModule.Point('B', 8, 9)
];
var line = new shapesModule.Line(linePoints, '#FFFF00');
console.log(line.toString());

var segmentPoints = [
	new shapesModule.Point('A', 0, 5),
	new shapesModule.Point('B', 14, 1)
];
var segment = new shapesModule.Segment(segmentPoints, '#FFFFFF');
console.log(segment.toString());
