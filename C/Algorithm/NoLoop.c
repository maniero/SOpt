void varreVetor(int vetor[5]) {
    for(int cont = 0; cont < 5; cont++) saida(vetor[cont]);
}
void mostrasaida(char recebido) {
    int dadoA[5] = {252, 146, 145, 146, 252};
    int dadoB[5] = {255, 201, 201, 201, 182};
    switch (recebido) {
        case 'A':
            varreVetor(dadoA);
            break;
        case 'B':
            varreVetor(dadoB);
            break;
    }
}

//https://pt.stackoverflow.com/q/142715/101
