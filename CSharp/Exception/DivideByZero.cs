if (num2 != 0) WriteLine($"O resultado de {num1} ÷ {num2} é {num1 / num2}");
else WriteLine("IMPOSSÍVEL DIVIDIR POR ZERO");

try {
    WriteLine($"O resultado de {num1} ÷ {num2} é {num1 / num2}");
} catch (DivideByZeroException) {
    WriteLine("IMPOSSÍVEL DIVIDIR POR ZERO");
}

//https://pt.stackoverflow.com/q/544031/101
