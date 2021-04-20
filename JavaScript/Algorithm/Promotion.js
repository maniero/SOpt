function calcula_media(i) {
    var n1 = document.getElementById("n1_aluno_" + i).value;
    var n2 = document.getElementById("n2_aluno_" + i).value;
    var media = document.getElementById("media_aluno_" + i);
    var resultado = document.getElementById("resultado_aluno_" + i);
    var calculo = (parseFloat(n1) + parseFloat(n2)) / 2;
    var contaAprovados = 0;
    var contaRecuperacao = 0;
    var contaReprovados = 0;
    if (calculo >= 70) {
        media.innerHTML = "<div class='text-success'>" + calculo + "</div>";
        resultado.innerHTML = "Aprovado";
        contaAprovados++;
    } else if (calculo >=30) {
        media.innerHTML = "<div class='text-rec'>" + calculo + "</div>";
        resultado.innerHTML = "Recuperaçao";
        contaRecuperacao++;
    } else {
        media.innerHTML = "<div class='text-danger'>" + calculo + "</div>";
        resultado.innerHTML = "Reprovado";
        contaReprovados++;
    }
}

//https://pt.stackoverflow.com/q/412207/101
