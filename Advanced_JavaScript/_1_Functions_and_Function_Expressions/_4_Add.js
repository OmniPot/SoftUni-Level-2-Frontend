function add(num) {
    var sum = function (x) {
        return add(num + x);
    };

    sum.valueOf = sum.toString = function () {
        return num;
    };

    return sum;
}

var addTwo = +add(2);
console.log(addTwo); //2

var addTwo = add(2);
console.log(+addTwo(3)(5)(1)(7)); //18