var ordinais = ['primeira', 'segunda', 'terceira', 'quarta'];
var media = 0;
var i = 0;
while (i < ordinais.length) {
    var nota = prompt("Informe a " + ordinais[i] + " nota: ");
    if (nota === "" || !nota) nota = 0;
    media += parseFloat(nota);
    i++;
}
media /= ordinais.length;
if (media >= 7) document.write("Aprovado");
else if (media <= 5) document.write("Reprovado");
else document.write("Recuperação");

//https://pt.stackoverflow.com/q/484122/101
