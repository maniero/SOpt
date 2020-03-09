var num1 = Number(window.prompt("Entre com primeiro numero"));
var num2 = Number(window.prompt("Entre com segundo numero"));
if (num1 >= 0 && num2 >= 0) {
    var i = Math.min(num1, num2);
    while (i <= Math.max(num1, num2)) console.log(i++);
}

var num1 = Number(window.prompt("Entre com primeiro numero"));
var num2 = Number(window.prompt("Entre com segundo numero"));
for (var i = Math.min(num1, num2); num1 >= 0 && num2 >= 0 && i <= Math.max(num1, num2); i++) console.log(i);

//https://pt.stackoverflow.com/q/154809/101
