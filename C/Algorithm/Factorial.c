#include <stdio.h>

int main(void) {
	int matriza[5], matrizb[5], indice, cont, soma;
	for (indice = 0; indice < 5; indice++) {
        printf("\n digite um valor: ");
        scanf("%d",&matriza[indice]);
        for (soma = 1, cont = matriza[indice]; cont > 1; cont--) soma *= cont;
        matrizb[indice] = soma;
	}
	for (indice = 0; indice < 5; indice++) printf("\n O valor do vetor B e: %d \n", matrizb[indice]);
}

//https://pt.stackoverflow.com/q/88745/101
