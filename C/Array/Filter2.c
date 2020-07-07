#include <stdio.h>
#define MAX 20

int main () {
    int vet[MAX];
    int contador = 0;
    for (int i = 0; i < MAX; i++) {
        printf("Digite o valor %i:",i+1);
        scanf("%i", &vet[i]);
        if (vet[i] > 10) contador++;
    }
    for (int i = 0; i < MAX; i++) if (vet[i] > 10) printf("Estes são os valores maiores que 10: %d\n", vet[i]);
    printf("Há este total de numeros maiores que 10: %d", contador);
}

//https://pt.stackoverflow.com/q/460979/101
