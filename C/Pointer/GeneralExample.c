#include <stdio.h>
#define MAX 3
float menor_nota(float valor[MAX]) {
	float menor = valor[0];
	for (int i = 1; i < MAX; i++) if (valor[i] < menor) menor = valor[i];
	return menor;
 }

int main() {
    float notas[MAX];
    printf("Informe a nota dos 30 alunos: ");
	for (int i = 0; i < MAX; i++) scanf("%f", &notas[i]);
	printf("\n A menor nota foi: %2.2f", menor_nota(notas));
}

//https://pt.stackoverflow.com/q/98389/101
