#include <stdio.h>

int main(void) {
    while (1) {
        float temp;
        puts("Graus Celsius:");
        scanf("%f", &temp);
        printf("\nCelsius: %.1f\nFahrenheit: %.1f\n", temp, temp * 1.8 + 32);
        puts("Digite 1 para sair ou 2 para uma nova conversao...\n");
        int sair;
        scanf("%d", &sair);
        if (sair == 1) break;
    }
}

//https://pt.stackoverflow.com/q/399689/101
