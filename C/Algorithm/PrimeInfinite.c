#include <stdio.h>

int main() {
    int i, numero;
    do {
        printf("Informe um numero primo maior que 1:");
        scanf("%d", &numero);
    } while (numero <= 1);
    for (i = 2; i < numero; i++) if (numero % i == 0) break;
    if (numero == i) printf("Numero primo %d", numero);
    else printf("Numero não primo %d", numero);
}

//https://pt.stackoverflow.com/q/85565/101
