function calculo(a, b, c, d) {
    return (a * b + c - a) / d;
}

var a = 10;
var b = 2;
var c = 2;
var d = 10;
var e = 2;
console.log('a = ' + a);
console.log('b = ' + b);
console.log('c = ' + c);
console.log('d = ' + d);
console.log('resultado = ' + calculo(a, b, c, d, e));
//note que a variável e não é usado em lugar algum, mesmo no original isso é um erro conceitual ainda que não dê erro

//https://pt.stackoverflow.com/q/401717/101
