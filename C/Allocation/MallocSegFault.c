#include <stdio.h>
#include <stdlib.h>

#define SUCESSO 0
#define FALHA -1

typedef struct {
    int x;
    int y;
} Ponto;

void criarPonto(Ponto **ponto) {
    (*ponto) = (Ponto *)NULL;
}

int preencherPonto(Ponto **ponto, int x, int y) {
    *ponto = malloc(sizeof(Ponto));
    if (*ponto == NULL) return FALHA;
    (*ponto)->x = x;
    (*ponto)->y = y;
    return SUCESSO;
}
int main() {
    Ponto *ponto;
    criarPonto(&ponto);
    printf("O endereco de memoria é: %p\n", (void *)ponto);
    if (preencherPonto(&ponto, 0, 1) == FALHA) return FALHA;
    printf("O endereco de memoria é: %p\n", (void *)ponto);
    printf("Coordenada X: %d\n", ponto->x);
    printf("Coordenada Y: %d\n", ponto->y);
    return SUCESSO;
}

//https://pt.stackoverflow.com/q/307590/101
