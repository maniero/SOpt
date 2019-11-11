#include <stdio.h>

int main() {
    int somaP = 0, quantN = 0, valores[10];
    for (int i = 0; i < 10; i++) {
        printf("Digite o %do valor: ", i + 1);
        scanf("%d", &valores[i]);
        if (valores[i] < 0) quantN++;
        else somaP += valores[i];
    }
    printf("\nSoma dos positivos: %d\n", somaP);
    printf("Quantidade de negativos: %d\n", quantN);
}

//https://pt.stackoverflow.com/q/420802/101
