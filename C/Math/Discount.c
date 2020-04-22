#include <stdio.h>

int main() {
    float valorT, valorF;
    int op;
    printf("Digite o valor total da sua compra: ");
    scanf("%f", &valorT);
    printf("Digite o numero da opcao de pagamento, estao listadas abaixo: \n");
    printf("1-Dinheiro\n2-Cartao debito\n3-Cartao credito 2x\n4-Cartao credito 3x\n");
    scanf("%d", &op);
    switch (op) {
    case 1:
        printf("O valor total da sua conta ficou: %0.2f", valorT * 0.9);
        break;
    case 2:
        printf("O valor total da sua conta ficou: %0.2f", valorT * 0.8);
        break;
    case 3:
        valorF = valorT * 1.1;
        printf("O valor total da sua conta ficou: %0.2f,\ne das 3 parcelas: %0.2f\n", valorF, valorF / 2);
        break;
    case 4:
        valorF = valorT * 1.15;
        printf("O valor total da sua conta ficou: %0.2f,\ne das 3 parcelas: %0.2f\n", valorF, valorF / 3);
        break;
    default:
        printf("Opcao invalida!\n");
    }
}

//https://pt.stackoverflow.com/q/447620/101
