#include <stdio.h>

int soma(void) {
    int valor = 0, soma = 0;
    printf("Foi escolhida a soma:\n\n");
    do {
        printf("Informe os valores desejados e 0 (zero) para concluir:");
        scanf("%d", &valor);
        soma += valor;
    } while (valor != 0);
    return soma;
}

int mult(void) {
    int valor = 0, mult = 1;
    printf("Foi escolhida a multiplicacao:\n\n");
    do {
        printf("Informe os valores desejados e 0 (zero) para concluir:");
        scanf("%d", &valor);
        if (valor == 0) break;
        mult *= valor;
    } while (valor != 0);
    return mult;
}

int main() {
    int op = 0, result;
    printf("Informe a operacao desejada soma(1) ou produto (2):");
    scanf("%d", &op);
    if (op == 1) result = soma();
    else if (op == 2) result = mult();
    printf("O resultado foi: %d", result);
}

//https://pt.stackoverflow.com/q/93032/101
