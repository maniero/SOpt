#include <stdio.h>
#include <stdlib.h>

void inicia(int v[5]) {
	for (int i = 0; i < 5; i++) v[i] = 1 + rand() % 20;
}

void mostra(int v[5]) {
	for (int i = 0; i < 5; i++) printf("%d\n", v[i]);
}

int main() {
	int vetor[5];
	inicia(vetor);
	mostra(vetor);
}

//https://pt.stackoverflow.com/q/173920/101
