#include <stdio.h>
#define MaxA 2
#define MaxB 3

int main(void) {
	int matriza[MaxA], matrizb[MaxB], matrizc[MaxA + MaxB], indice;
	for (indice = 0; indice < MaxA; indice++) {
        printf("\n digite o valor da matriz A: ");
        scanf("%d", &matriza[indice]);
        matrizc[indice] = matriza[indice];
    }
	for (indice = 0; indice < MaxB; indice++) {
        printf("\n digite o valor da matriz B: ");
        scanf("%d", &matrizb[indice]);
        matrizc[indice + MaxA] = matrizb[indice];
    }
	for (indice = 0; indice < MaxA + MaxB; indice++) printf("\n Os valores das matrizes A e B sao: %d \n", matrizc[indice]);
}

//https://pt.stackoverflow.com/q/89153/101
