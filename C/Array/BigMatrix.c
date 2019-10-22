#include <stdio.h>
#include <stdlib.h>
#define linhas 2000
#define colunas 2000

int main() {
	int * matriz = malloc(linhas * colunas * sizeof(int));
	matriz[0 * linhas + 0] = 0; //coloca um valor na primeira posição da "matriz"
	printf("%d", matriz[0 * linhas + 0]); //claro que neste caso se colocasse apenas 0 funcionaria
	free(matriz);
}

//https://pt.stackoverflow.com/q/91719/101
