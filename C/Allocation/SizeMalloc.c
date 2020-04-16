#include <stdio.h>
#include <stdlib.h>
#define TAMANHO 10

int main(void) {
    int *vetor = malloc(TAMANHO * sizeof(int));
    for (int i = 0; i < TAMANHO ; i++) {
    	vetor[i] = i + 1;
    	printf("%d\n", vetor[i]);
    }
    printf("\n%d", TAMANHO);
}

//https://pt.stackoverflow.com/q/446320/101
