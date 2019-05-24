#include <stdio.h>
#include <stdlib.h>

struct conjunto {
    size_t tamanho;
    int conteudo[];
};

int main(void) {
	struct conjunto *dados = malloc(sizeof(struct conjunto) * 10);
    dados->tamanho = 10;
    for (int i = 0; i < dados->tamanho; i++) dados->conteudo[i] = i;
    for (int i = 0; i < dados->tamanho; i++) printf("%d, ", dados->conteudo[i]);
}

//https://pt.stackoverflow.com/q/373428/101
