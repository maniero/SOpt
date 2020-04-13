#include <stdio.h>

int media(int vet[], int posicao) {
    if (posicao == 0) return 0;
    else if (posicao == 5) return (vet[posicao - 1] + media(vet, posicao - 1)) / 5;
    else return vet[posicao - 1] + media(vet, posicao - 1);
}

int main() {
    int vet[5] = {4, 2, 1, 6, 7};
    printf("%d", media(vet, 5));
}

//https://pt.stackoverflow.com/q/445744/101
