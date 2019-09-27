#include <stdio.h>

int main() {
    int num1, num2, i, j;
    char op;
    do {
        printf("\nInforme um numero: ");
        scanf("%i", &num1);
        printf("\nInforme um numero: ");
        scanf("%i", &num2);
        for (i = num1; i <= num2; i++) {
        	for (j = 2; j < i; j++) if (i % j == 0) break;
            if (i == j) printf("\n%i - Primos!", i);
            else printf("\n%i - Nao primos!", i);
        }
        printf("\nDeseja calcular outra sequencia de numeros? ");
        scanf("%s", &op);
    } while (op == 's' || op == 'S');
}

//https://pt.stackoverflow.com/q/84040/101
