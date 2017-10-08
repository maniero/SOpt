#include <stdio.h>
#include <stdlib.h>

void mTransposta(int linhas, int colunas, int matriz[][colunas]) {
	int matrizTransposta[linhas][colunas];
     for (int i = 0; i < linhas; i++) {
        for (int j = 0; j < colunas; j++) {
            matrizTransposta[i][j] = matriz[i][j];
        }
        printf("\n");
    }
   for (int i = 0; i < linhas; i++) {
        for (int j = 0; j < colunas; j++) {
            printf("%4d", matrizTransposta[i][j]);
        }
        printf("\n");
    }
}

void mValores() {
    int linhas, colunas;
    printf("\nDigite a quantidade de linhas: \n");
    scanf("%d", &linhas);
    printf("Digite a quantidade de Colunas: \n");
    scanf("%d", &colunas);
    int matriz[linhas][colunas];
    printf("Matriz do tipo: %dx%d ", linhas, colunas);
    if (linhas == colunas) {
        printf("(Matriz quadrada).");
    } else if (linhas == 1 && colunas > 1) {
        printf("(Matriz linha).");
    } else if(linhas > 1 && colunas == 1) {
        printf("(Matriz coluna).");
    }
    printf("\n");
    for (int i = 0; i < linhas; i++) {
        for (int j = 0; j < colunas; j++) {
            printf("a%d%d ", i + 1, j + 1);
        }
        printf("\n");
    }
    printf("Digite os valores de: \n");
    for (int i = 0; i < linhas; i++) {
        for (int j = 0; j < colunas; j++) {
            printf("a%d%d ", i + 1, j + 1);
            scanf("%d", &matriz[i][j]);
        }
    }
    printf("\n");
    for (int i = 0; i < linhas; i++) {
        for (int j = 0; j < colunas; j++) {
            printf("%4d", matriz[i][j]);
        }
        printf("\n");
    }
    printf("\n");
    mTransposta(linhas, colunas, matriz);
}

int main() {
    int end;
    printf("\n***CALCULOS DE MATRIZES*** \n");
    do {
        printf("\nMatriz Transposta\n");
        mValores();
        printf("\nDigite 1 para sair ou digite qualquer outro numero para Continuar:\n");
        scanf("%d", &end);
    } while (end != 1);
}

//https://pt.stackoverflow.com/q/244422/101
