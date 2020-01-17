#include<stdio.h>
#include<stdlib.h>
int main() {
	int *vetor, contador = 0; 
	char c;
	vetor = malloc(sizeof(int));
	while (1) {
		printf("Digite um valor para salvar no vetor: ");
		scanf("%d", &vetor[contador]);
		printf("Deseja cadastrar mais um numero? ");
		scanf(" %c", &c);
		contador++;
		if (c != 's' && c != 'S') break;
        vetor = realloc(vetor, sizeof(int) * (contador + 1));
	}
	for (int i = 0; i < contador; i++) printf(" (%d) ", vetor[i]);
}

//https://pt.stackoverflow.com/q/132158/101
