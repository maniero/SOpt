#include <stdio.h>

int main(void) {
    int tam;
    printf("Digite o tamanho: ");
    scanf("%d", &tam);
    int vet[tam];
    for (int i = 1; i <= tam; i++) vet[i] = i;
    for (int i = 1; i <= tam; i++) printf("%d ", vet[i]);
}

//https://pt.stackoverflow.com/q/34060/101
