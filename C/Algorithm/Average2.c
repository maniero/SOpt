#include <stdio.h>
#include <stdlib.h>

int *proximo_da_media(int *vec, int size) {
    int *pos = vec;
    float soma = 0;
    for (int i = 0; i< size; i++) soma += pos[i];
    float media = soma / size + 0.5f;
    float diferenca = abs(*pos - media);
    for (int i = 0; i < size;i++) {
        if (abs(pos[i] - media) < diferenca) {
            diferenca = abs(pos[i] - media);
            vec = &pos[i];
        }
    }
    return vec;
}

int main() {
    int tabela[10] = {20, 30, 43, 5, 400, 1999, 9, 360, 3, 8};
    int *posicao = proximo_da_media(tabela, 10);
    printf("O endreco do ponteiro que aponta para o numero mais proximo da media e o %p e tem o valor %d\n", (void *)posicao, *posicao);
}

//https://pt.stackoverflow.com/q/287889/101
