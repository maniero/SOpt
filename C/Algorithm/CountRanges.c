#include <stdio.h>

int main() {
    int abaixo2000 = 0, acima2000 = 0;
    while (1) {
        float salario;
        printf("Digite o seu salario (para cancelar digite -1): ");
        scanf("%f", &salario);
        if (salario == -1) break;
        if (salario < 2000) abaixo2000++;
        else acima2000++;
    }
    printf("Pessoas com salario maior de 2000.00 reais: %d\ne menor de 2000.00 reais: %d\n", acima2000, abaixo2000);
}

//https://pt.stackoverflow.com/q/446768/101
