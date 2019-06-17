#include<stdio.h>

int main() {
    int a, b, operacao;
    printf("digite o primeiro numero:\n");
    scanf("%d", &a);
    printf("digite o segundo numero:\n");
    scanf("%d", &b);
    printf("Qual operacao voce deseja ?\n");
    printf(" 1 Soma\n 2 Subtracao\n 3 Multiplicacao\n 4 Divisao\n");
    scanf("%d", &operacao);
    switch (operacao) {
    case 1:
        printf("voce escolheu soma %d", a + b);
        break;
    case 2:
        printf("voce escolheu Subtracao %d", a - b);
        break;
    case 3:
        printf("voce escolheu Multiplicacao %d", a * b);
        break;
    case 4:
        printf("voce escolheu Divisao %d", a / b);
        break;
    }
}

//https://pt.stackoverflow.com/q/391675/101
