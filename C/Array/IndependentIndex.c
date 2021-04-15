#include <stdio.h>
#include <stdlib.h>
#define MAX 5

int main() {   
    int menores[MAX], maiores[MAX], cont_menores = 0, cont_maiores = 0;
    for (int i = 0; i < MAX; i++) {
        printf("Digite: ");
        int numero;
        scanf("%d", &numero);
        if (numero > 10) maiores[cont_maiores++] = numero;
        else menores[cont_menores++] = numero;
    }
    for (int i = 0; i < cont_menores; i++) printf("%d ", menores[i]);
    printf("\n");
    for (int i = 0; i < cont_maiores; i++) printf("%d ", maiores[i]);
}

//https://pt.stackoverflow.com/q/505074/101
