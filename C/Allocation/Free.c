#include <stdio.h>
#include <stdlib.h>

int* copia(int *vet, int tam) {
    int *retorno = malloc(tam * sizeof(int));
    for (int i = 0; i < tam; i++) retorno[i] = vet[i];
    return retorno;
}

int main(void) {
	int tam = 3;
    int *vet = malloc(tam * sizeof(int));
    vet[0] = 1;
    vet[1] = 2;
    vet[2] = 3;
	int *novo = copia(vet, tam);
	printf("0 -> %d\n", novo[0]);
	printf("1 -> %d\n", novo[1]);
	printf("2 -> %d\n", novo[2]);
	free(novo);
}

//https://pt.stackoverflow.com/q/102162/101
