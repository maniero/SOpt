#include <stdio.h>

int main () {
	int assentos[300];
	char nomes[300][15];
	int ocupados[50][6] = { 0 };
	int contadorAssentos = 0;
	char escolha;
	do { 
		printf("\nDigite o nome do passageiro: ");
		scanf("%s", nomes[contadorAssentos]);
		printf("\nDigite o numero do assento requerido: ");
		scanf("%d", &assentos[contadorAssentos]);
		printf("\nNome do passageiro: %s", nomes[contadorAssentos]);
		printf("\nAssento escolhido: %d", assentos[contadorAssentos]);
		ocupados[(assentos[contadorAssentos] - 1) / 6][assentos[contadorAssentos] - 1 - ((assentos[contadorAssentos] - 1) / 6) * 6] = 1;
		if (contadorAssentos++ == 300) {
			break;
		}
		printf("\nDeseja continuar? <S/N>");
		scanf(" %c", &escolha);
	} while (escolha == 'S' || escolha == 's');
	printf("\n");
	for (int i = 0; i < 50; i++) {
		for (int j = 0; j < 6; j++) {
			printf("F%02dA%d=%s | ", i + 1, j + 1, ocupados[i][j] ? "ocupado" : "livre  ");
		}
		printf("\n");
	}
}

//http://pt.stackoverflow.com/q/186611/101
