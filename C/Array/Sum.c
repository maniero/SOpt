#include <stdio.h>

int main() {
	int valores[4][4];
	for (int i = 0; i < 4; i++) {
	    for (int j = 0; j < 4; j++) {
			printf("Informe os valores de [%d, %d]:\n", i + 1, j + 1);
			scanf("%d", &valores[i][j]);
		}
	}
	for (int i = 0; i < 4; i++) {                     
	    for (int j = 0; j < 4; j++) printf("%d\t", valores[i][j]);
		printf("\n");
	}
	for (int i = 0; i < 4; i++) {
		int soma = 0;
	    for (int j = 0; j < 4; j++)	soma += valores[i][j];
 		printf("Soma da linha %d: %d\n", i + 1, soma);
	}
	for (int i = 0; i < 4; i++) {
		int soma = 0;
	    for (int j = 0; j < 4; j++)	soma += valores[j][i];
 		printf("Soma da coluna %d: %d\n", i + 1, soma);
	}
}

//https://pt.stackoverflow.com/q/89261/101
