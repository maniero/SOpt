#include <stdio.h>
#include <stdlib.h>

#define SUCESSO 0
#define FALHA -1

typedef struct {
    int x;
    int y;
} Ponto;

void preencherPonto(Ponto *ponto, int x, int y) {
    ponto->x = x;
    ponto->y = y;
}
int main() {
    Ponto *ponto = malloc(sizeof(Ponto));
    if (ponto == NULL) return FALHA;
    preencherPonto(ponto, 0, 1);
    printf("O endereco de memoria é: %p\n", (void *)ponto);
    printf("Coordenada X: %d\n", ponto->x);
    printf("Coordenada Y: %d\n", ponto->y);
    free(ponto);
    return SUCESSO;
}

//https://pt.stackoverflow.com/q/307590/101
