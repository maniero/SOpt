var x = {
    i: 1,
    toString: function() { return this.i++; }
}
console.log(typeof(x));
console.log(typeof(1));
console.log(x == 1 && x == 2 && x == 3);

var x = {
    i: 1,
    toString: function() { return this.i++; }
}
console.log(x.toString() == "1");

var x = {
    i: 1,
    toString: function() { return this.i++; }
}
console.log(x === 1 && x === 2 && x === 3);

var x = {
    i: 1,
    valueOf: function() { return this.i++; },
    toString: function() { return this.i++; }
}
console.log(x == 1 && x == 2 && x == 3);
console.log(typeof(x.valueOf()));

//https://pt.stackoverflow.com/q/577181/101
