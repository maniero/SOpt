function calculo(a, b) {
return { adicao : a + b, subtracao : a - b, multiplicacao : a * b, divisao : a / b, };
}

var resultados = calculo(10, 2, 2, 10, 2);
console.log('adicao = ' + resultados.adicao);
console.log('subtracao = ' + resultados.subtracao);
console.log('multiplicacao = ' + resultados.multiplicacao);
console.log('divisao = ' + resultados.divisao);

//https://pt.stackoverflow.com/q/401717/101
