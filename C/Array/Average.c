#include <stdio.h>

int main(void) {
    int matriz [3][3] = {{0}};
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            printf("introduza numeros para a matriz nos lugares [%d][%d] \n", i+1, j+1);
            scanf("%d", &matriz[i][j]);
        }
    }
    printf("\n\testes sao os valores da matriz\n\n");
    printf("\t\t matriz ordenada");
    int soma = 0;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
           soma += matriz[i][j];
        }
    }
    printf("\nMédia: %d", soma / 9);
}

//https://pt.stackoverflow.com/q/220778/101
