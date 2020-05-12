#include <stdio.h>

int main(void) {
    int contador = 0;
    int d[16];
    printf("Digite o número do seu cartão de crédito:\n");
    long number_cartao;
    scanf("%ld", &number_cartao);
    printf("%ld\n", number_cartao);
    while (number_cartao != 0) {
        number_cartao /= 10;
        d[++contador] = number_cartao;
    }
    printf("Seu cartão tem %d números.\n", contador);
    printf("Item 0: %d", d[0]);
}

//https://pt.stackoverflow.com/q/451142/101
