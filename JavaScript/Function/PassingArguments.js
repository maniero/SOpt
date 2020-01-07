function calculo(num1, num2, operacao){
    if (operacao == 'soma') return num1 + num2;
    else if (operacao == 'subtracao') return num1 - num2;
}

var num1 = parseInt(prompt("Digite um número: "));
var operacao = prompt("Digite a operação: ");
var num2 = parseInt(prompt("Digite outro número: "));
document.write(calculo(num1, num2, operacao));

//https://pt.stackoverflow.com/q/429521/101
