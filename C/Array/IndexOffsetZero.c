#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(void) {
	int n;
	char op = 's';
	do {
		printf("Digite a quantidade de equipes para serem sorteadas: ");
		scanf("%d", &n);
		printf("\n--------------------------------------------------------------------------------------------\n");
		int matriz[2][n];
		for (int cont1 = 0; cont1 < n; cont1++) {
			matriz[0][cont1] = cont1 + 1;
			matriz[1][cont1] = cont1 + 1;
		}
		srand(time(NULL));
		for (int cont1 = 0; cont1 < n; cont1++) {
			int sorteio = rand() % n;
			int aux = matriz[1][cont1];
			matriz[1][cont1] = matriz[1][sorteio];
			matriz[1][sorteio] = aux;
		}
		for (int cont1 = 0; cont1 < n; cont1++) {
			printf("Linha 1 da MATRIZ - Ordem das Apresentações: %d   |   ", matriz[0][cont1]);
			printf("Linha 2 da MATRIZ - Número da Equipe: %d\n", matriz[1][cont1]);
		}
		printf("\n--------------------------------------------------------------------------------------------\n\n");
		printf("Deseja realizar outro sorteio? (S/N)> ");
		op = getchar();
		printf("\n--------------------------------------------------------------------------------------------\n\n");
	} while (op == 'S' || op == 's');
}

//https://pt.stackoverflow.com/q/345824/101
