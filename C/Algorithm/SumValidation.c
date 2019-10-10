#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int  main() {
    setlocale(LC_ALL, "Portuguese");
    int qtde, aux;
    float valorCheque, valorTotal = 0, totalLote;
    printf("Digite a quantidade de cheques: ");
    scanf("%d", &qtde);
    printf("Digite a soma do lote: ");
    scanf("%f", &totalLote);
    for (aux = 0; aux < qtde; aux++) {
        printf("Insira o valor do cheque: ");
        scanf("%f", &valorCheque);
        valorTotal += valorCheque;
    }
    printf("Soma total dos cheques: %f", totalLote);
    printf("Valor total dos cheques: %f", valorTotal);
    if (totalLote == valorTotal) printf("Lote ok");
    else if (totalLote > valorTotal) printf("Diferença negativa");
    else printf("Diferença positiva");
}

//https://pt.stackoverflow.com/q/89080/101
