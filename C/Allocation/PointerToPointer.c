#include <stdio.h>
#include <stdlib.h>
 
void alocaMatriz(int **matriz, int lin, int col){
    matriz = (int **)malloc(lin * sizeof(int **));
    for (int i = 0; i < col; i++) matriz[i] = (int *)malloc(col * sizeof(int));
}
 
void leMatriz(int **matriz, int lin, int col){
    printf("\nDigite os valores: ");
    for (int i = 0; i < lin; i++) for (int j = 0; j < col; j++) scanf("%d", &matriz[i][j]);
}
 
int main(int argc, char** argv) {
    int lin, col;
    int **matriz;
    printf("Digite as dimensoes da matriz: ");
    scanf("%d %d", &lin, &col);
    alocaMatriz(matriz, lin, col);
    leMatriz(matriz, lin, col);
}

//https://pt.stackoverflow.com/q/235435/101
