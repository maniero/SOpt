#include <stdio.h>
#include <locale.h>

int main() {
    setlocale(LC_ALL, "Portuguese");
    printf("===============\n");
    printf("CALCULADORA 1.0");
    printf("\n===============\n");
    printf("Digite Dois Números a serem calculados:\n");
    printf("Primeiro Número:\n");
    int num1, num2;
    scanf("%d", &num1);
    printf("Segundo Número:\n");
    scanf("%d", &num2);
    printf("A soma é: %d\n", num1 + num2);
    printf("A subtração é: %d \n", num1 - num2);
    printf("O produto é: %d \n", num1 * num2);
    printf("A divisão é: %d \n", num1 / num2);
}

//https://pt.stackoverflow.com/q/421317/101
