#include <stdio.h>

int main() {
    int num1, num2;
    printf("Digite o numero A e numero B para saber o resto da divisao resultante da divisao entre eles:\n");
    printf("NumeroA: "); scanf("%d", &num1);
    printf("\n");
    printf("NumeroB: "); scanf("%d", &num2);
    printf("O resto da divisao e: %d", num1 % num2);
}

//https://pt.stackoverflow.com/q/252692/101
