using static System.Console;
					
if (!double.TryParse(ReadLine(), out var n1)) return;
if (!double.TryParse(ReadLine(), out var n2)) return;
if (!double.TryParse(ReadLine(), out var n3)) return;
double menor = n1;
double maior = n1;
if (n2 > maior) maior = n2;
if (n3 > maior) maior = n3;
if (n2 < menor) menor = n2;
if (n3 < menor) menor = n3;
WriteLine($"O maior número é: {maior} e o menor número é: {menor}");

//https://pt.stackoverflow.com/q/496656/101
