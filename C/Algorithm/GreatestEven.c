#include <stdio.h>

int qtde_impar(int vetor[], int tamanho) {
	int maior = 1; //precisaria ver se pode ter valores negativos
	for (int cont = 0; cont < 10 ; cont++) if (vetor[cont] % 2 == 1 && vetor[cont] > maior) maior = vetor[cont];
	return maior;
}

int main() {
	int vetor[10] = { 8, 2, 1, 4, 5, 3, 7, 2, 9, 0 };
	printf("%i\n", qtde_impar(vetor, 10));
}

//https://pt.stackoverflow.com/q/212605/101
