#include <stdio.h>
#include <float.h>

int main(void) {
	int qntd, n;
	printf ("Digite a quantidade de elementos: ");
	scanf ("%d", &qntd);
	printf ("Ate onde considerar: ");
	scanf ("%d", &n);
	float vet[qntd], maior = FLT_MIN;
	for (int i = 0; i < qntd; i++) {
	    printf ("Digite um numero: ");
	    scanf ("%f", &vet[i]);
	    if (i < n && vet[i] > maior) maior = vet[i];
	}
	printf ("Maior = %.2f \n", maior);
}

//https://pt.stackoverflow.com/q/412993/101
