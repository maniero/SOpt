#include <stdio.h>

int main() {
    int somaPositivos = 0, somaNegativos = 0, negativos = 0;
    for (int i = 0; i < 20; i++) {
        printf("\nDigite um numero");
        int numero;
        scanf("%d", &numero);
        if (numero < 0) {
            somaNegativos += numero;
            negativos++;
        } else somaPositivos += numero;
    }
    printf("A media dos numeros negativos é de:  %f\n", (float)somaNegativos / negativos);
    printf("A soma dos numeros positivos é: %d\n", somaPositivos);
}

//https://pt.stackoverflow.com/q/326587/101
