var shapesModule = shapesModule || {};

var canvas = document.getElementById('canvas');
var ctx = canvas.getContext('2d');

var rectangleTopLeftPoint = Object.create(shapesModule.point).init('A', 100, 100);
var rect = Object.create(shapesModule.rectangle).init(rectangleTopLeftPoint, 200, 200, '#0000FF');

var circleCenterPoint = Object.create(shapesModule.point).init('O', 100, 100);
var circle = Object.create(shapesModule.circle).init(circleCenterPoint, 75, 'rgba(255, 0, 0, 0.5)');

var trianglePoints = [
	Object.create(shapesModule.point).init('A', 250, 50),
	Object.create(shapesModule.point).init('B', 400, 125),
	Object.create(shapesModule.point).init('C', 125, 240)
];
var triangle = Object.create(shapesModule.triangle).init(trianglePoints, 'rgba(0, 255, 0, 0.7)');

var linePoints = [
	Object.create(shapesModule.point).init('A', 0, 0),
	Object.create(shapesModule.point).init('B', 100, 400),
];
var line = Object.create(shapesModule.line).init(linePoints, 'rgba(0, 0, 0, 0.4)');

var segmentPoints = [
	Object.create(shapesModule.point).init('A', 40, 160),
	Object.create(shapesModule.point).init('B', 80, 320),
];
var segment = Object.create(shapesModule.segment).init(segmentPoints, 'rgb(255, 255, 0)');

rect.draw(ctx);
circle.draw(ctx);
triangle.draw(ctx);
line.draw(ctx);
segment.draw(ctx);