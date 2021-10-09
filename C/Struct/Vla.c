#include <stdio.h>
#include <stdlib.h>

typedef struct {
    size_t tamanho;
    int conteudo[];
} Conjunto;

int main(void) {
	Conjunto *dados = malloc(sizeof(Conjunto) + 10 * sizeof(int));
    dados->tamanho = 10;
    for (int i = 0; i < dados->tamanho; i++) dados->conteudo[i] = i;
    for (int i = 0; i < dados->tamanho; i++) printf("%d, ", dados->conteudo[i]);
}

//https://pt.stackoverflow.com/q/373428/101
