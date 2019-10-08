var numero = 101;
var divisor = 1, dividido = 0;
for (var  i = 0; i < numero; i++) {
    dividido = numero / divisor;
    divisor = (dividido + divisor) / 2;
}
console.log(divisor);

//https://pt.stackoverflow.com/q/414747/101
