function calcMedia(a, b) {
    return (a + b) / 2;
}
var numAlunos = parseFloat(prompt("Quanto alunos você deseja verficar? "));
for (var i = 0; i < numAlunos; i++) {
    var aluno = prompt("Qual o seu nome? ");
    var nota1 = parseFloat(prompt("Digite sua 1ª nota: "));
    var nota2 = parseFloat(prompt("Digite sua 2ª nota: "));
    console.log(aluno);
    console.log(nota1);
    console.log(nota2);
    console.log(calcMedia(nota1, nota2));
    console.log("");
}

//https://pt.stackoverflow.com/q/354554/101
