function avaliaPontuacoes (stringPontuacoes) {
    let pontuacoes = stringPontuacoes.split(", ");
    let qtdQuebraDeRecords = 0;
    let piorJogo = 1;
    let maiorPontuacao = pontuacoes[0];
    let menorPontuacao = pontuacoes[0];
    for (let i = 1; i < pontuacoes.length; i++) {
        let pontuacao = parseInt(pontuacoes[i]);
        if (pontuacao > maiorPontuacao) {
            maiorPontuacao = pontuacao;
            qtdQuebraDeRecords++;
        } else if (pontuacao < menorPontuacao) {
            menorPontuacao = pontuacao;
            piorJogo = i + 1;
        }
    }
    return [qtdQuebraDeRecords, piorJogo];
}

console.log(avaliaPontuacoes("10, 20, 4, 8, 9, 22, 12, 43, 22"));

//https://pt.stackoverflow.com/q/505750/101
