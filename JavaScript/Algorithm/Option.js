var n1 = parseInt(prompt("Digite um número"));
var n2 = parseInt(prompt("Digite outro número"));
var A = n1 + n2;
var M = n1 * n2;
var D = n1 / n2;
var Sub = n1 - n2;
var menu = prompt("Escolha uma opção:\nA - Adição\nM - Multiplicação\nD - Divisão \nS - Subtração")
if (menu == "A") {
    alert(A);
} else if (menu == "M") {
    alert(M);
}

//https://pt.stackoverflow.com/q/298448/101
