#include <stdio.h>
#include <stdlib.h>
#define LINHA 3
#define COLUNA 4

void matriz_ponteiro(int **mtr, size_t linhas, size_t colunas) {
     for (int lin = 0; lin < linhas; lin++) {
        for (int col = 0; col < colunas; col++) printf("\t%d", mtr[lin][col]);
  
        printf("\n");
    }
}

int main () {
    int **mtr = malloc(LINHA * sizeof(*mtr));
    for (int lin = 0, cont = 0; lin < LINHA; lin++) {
    	mtr[lin] = malloc(COLUNA * sizeof(*mtr[lin]));
        for (int col = 0; col < COLUNA; col++) mtr[lin][col] = cont++;
    }
    matriz_ponteiro(mtr, LINHA, COLUNA);
}

//https://pt.stackoverflow.com/q/165524/101
