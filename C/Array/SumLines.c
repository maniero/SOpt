#include <stdio.h>
#include <string.h>

int main() {
	int linhas , colunas;
	printf("\nDigite o numero de linhas da matriz: ");
	scanf("%d", &linhas);
	printf("\nDigite o numero de colunas da matriz: ");
	scanf("%d", &colunas);
	float matriz[linhas][colunas];
	float soma = 0;
	float somaLinhas[linhas];
	memset(somaLinhas, 0, sizeof(somaLinhas));
	for (int linha = 0; linha < linhas; linha++) {
		for (int coluna = 0; coluna < colunas; coluna++) {
			printf("\nDigite o %d valor para a %d linha: ", coluna + 1, linha + 1);
			scanf("%f", &matriz[linha][coluna]);
			soma += matriz[linha][coluna];
			somaLinhas[linha] += matriz[linha][coluna];
 		}
	}
	printf("\n");
	for (int linha = 0; linha < linhas; linha++) {
		for (int coluna = 0; coluna < colunas; coluna++) printf("%5.2f ",matriz[linha][coluna]);
		printf("\n");
	}
	for (int linha = 0; linha < linhas; linha++) printf("\nA soma da linha %d eh %5.2f", linha, somaLinhas[linha]);
	printf("\nA soma total eh  %5.2f", soma);
}

//https://pt.stackoverflow.com/q/328211/101
