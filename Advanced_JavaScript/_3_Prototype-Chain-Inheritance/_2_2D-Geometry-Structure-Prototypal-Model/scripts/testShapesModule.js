var shapesModule = shapesModule || {};

var circleCenterPoint = Object.create(shapesModule.point).init('O', 4, 3);
var circle = Object.create(shapesModule.circle).init(circleCenterPoint, 5, '#FF0000');
console.log('Circle:\n' + circle.toString());

var rectangleTopLeftPoint = Object.create(shapesModule.point).init('A', 1, 2);
var rect = Object.create(shapesModule.rectangle).init(rectangleTopLeftPoint, 20, 20, '#0000FF');
console.log('Rectangle:\n' + rect.toString());

var trianglePoints = [
	Object.create(shapesModule.point).init('A', 5, 5),
	Object.create(shapesModule.point).init('B', 2, 3),
	Object.create(shapesModule.point).init('C', 4, 1)
];

var triangle = Object.create(shapesModule.triangle).init(trianglePoints, '#00FF00');
console.log('Triangle:\n' + triangle.toString());

var linePoints = [
	Object.create(shapesModule.point).init('A', 1, 1),
	Object.create(shapesModule.point).init('B', 7, 8),
];
var line = Object.create(shapesModule.line).init(linePoints, '#FFFF00');
console.log('Line:\n' + line.toString());

var segment = Object.create(shapesModule.segment).init(linePoints, '#FFFFFF');
console.log('Segment: \n' + segment.toString());