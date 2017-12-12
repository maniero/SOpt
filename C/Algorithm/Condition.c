#include <stdio.h>

void filtro(int tamanho, int vet[]) {
    for (int i = 0; i < tamanho; i++) if (vet[i] <= -4 || vet[i] >= 4) return;
    printf("Está executando um método\n");
}
int main(void) {
    int vet[] = { 1, 2, 3, 4 };
    filtro(3, vet); //não conssiderará o último elemento que não encaixa no filtro
    printf("Agora não vai passar pelo filtro");
    filtro(4, vet);
}

//https://pt.stackoverflow.com/q/257565/101
