#include <stdio.h>

int quant(int num1, int num2) {
    return num1 < num2 ? quant(num1 + 1, num2) + (num1 % 2 == 0) : 0;
}

int main(int argc, char** argv) {
    int n1,n2;
    printf("Digite o primeiro numero: ");
    scanf("%d", &n1);
    printf("Digite o segundo numero, maior que o primeiro: ");
    scanf("%d", &n2);
    printf("A quantidade de pares entre %d e %d e' %d", n1, n2, quant(n1, n2));
    return 0;
}

//https://pt.stackoverflow.com/q/286773/101
