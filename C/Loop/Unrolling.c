for (int i = 0; i < 4; i++) {
    soma += dados[i];
}

//se tranforma em

soma = dados[0] + dados[1] + dados[2] + dados[3];

//Mas quando não se sabe o tamanho o melhor que pode fazer é:

for (int i = 0; i < n; i++) {
    soma += dados[i];
}

//Ser transformado em:

for (int i = 0; i < n; i += 4) {
    soma0 += dados[i + 0];
    soma1 += dados[i + 1];
    soma2 += dados[i + 2];
    soma3 += dados[i + 3];
}
soma = soma0 + soma1 + soma2 + soma3;

//http://pt.stackoverflow.com/q/186216/101
