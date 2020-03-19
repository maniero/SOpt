#include <stdio.h>
#include <stdlib.h>

int *aloca(int *vetorInt, int tamanho) {
	vetorInt = malloc(tamanho * sizeof(int));
    if (vetorInt != NULL) printf("*** VETOR ALOCADO.\nENDERECO NA FUNCAO: %d ***\n", vetorInt);
    else printf("*** NAO ALOCADO ***\n");
    return vetorInt;
}

int main (void) {
    int *vetor = aloca(vetor, 2);
    printf("END. NA MAIN: %d", vetor);
}

//https://pt.stackoverflow.com/q/164491/101
