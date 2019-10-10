#include <stdio.h>

int main(void) {
    int matriza[10];
    int matrizB[10];
    int indice;
    for (indice = 0; indice < 10; indice++) {
        printf("digite um valor numerico inteiro: ");
       scanf ("%d", &matriza[indice]);
     }
    for (indice = 0; indice < 10; indice++) {
        if (indice % 2 == 0) matrizB[indice] = matriza[indice] * 5;
        else matrizB[indice] = matriza[indice] + 5;
    }
    for (indice = 0; indice < 10; indice++) printf ("\nConteudo da matriz a indice %d = %d", indice, matriza[indice]);
    for (indice = 0; indice < 10; indice++) printf ("\nConteudo da matriz B indice %d = %d", indice, matrizB[indice]);
}

//https://pt.stackoverflow.com/q/88279/101
