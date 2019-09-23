var nomeAluno = ["Gabriel", "Joao", "Maria", "Joaquim", "Joana"];
var np1 = [10, 9.2, 7, 0, 10];
var np2 = [7, 10, 9, 3, 9.8];

function calculaMedia(nota1, nota2){
    return (nota1 + nota2) / 2;
}

function condicao(media){
    return media >= 7 ? "Aluno aprovado!" : "Aluno reprovado";
}

for (let i in nomeAluno) {
    let media = calculaMedia(np1[i], np2[i]);
    console.log("Aluno, " + nomeAluno[i] + ", NP1: " + np1[i] + ", NP2: " + np2[i] + " Média: " + media + ", Condição: " + condicao(media) +"\n");
}

//https://pt.stackoverflow.com/q/411891/101
