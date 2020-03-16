var idade = [];
for (var i = 0; i < 3; i++) idade[i] = parseInt(prompt("Informe a primeira idade: "));
var media = 0;
for (var i = 0; i < 3; i++) media += idade[i];
media /= 3;
if (media >= 6) document.write("Aprovado");
else if (media <= 5) document.write("Reprovado");
else document.write("Recuperação");

//https://pt.stackoverflow.com/q/159100/101
