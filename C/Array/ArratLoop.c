#include <stdio.h>

int main() {
    int vetor[4], cont=0;
    for (int i = 0; i < 4; i++) {
        printf("Introduza a %da. idade: ", i + 1);
        scanf("%d", &vetor[i]);
        if (vetor[i] >= 18) cont++;
    }
    printf("Das 4 idades inseridas, %d sao maiores de idade.", cont);
}

//https://pt.stackoverflow.com/q/311194/101
