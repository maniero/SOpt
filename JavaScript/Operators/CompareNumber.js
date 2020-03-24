var chute = Math.round(parseInt(prompt("Adivinhe em qual número estou pensando")));
if (!isNaN(chute)) document.write("Ops! Devido a algum erro, não pude receber seus dados, certifique-se de colocar números, de preferência, inteiros")
var numeroPensado = Math.round(Math.random() * 100);
if (chute != numeroPensado) document.write("Que pena, você errou, o número em que eu pensei era " + numeroPensado);
else document.write("Parabéns, você acertou !");

//https://pt.stackoverflow.com/q/167550/101
