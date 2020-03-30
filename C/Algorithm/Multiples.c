#include <stdio.h>

int main(void) {
	int n, i, j, multiplosI = 0, multiplosJ = 0, multiplos = 0;
	printf("Digite o valor de N: ");
	scanf("%d", &n);
	printf("Digite o valor de I e J: ");
	scanf("%d %d", &i, &j);
	for (int contador = 1; contador < n; contador++) {
	    if (contador % i == 0) multiplosI++;
	    if (contador % j == 0) multiplosJ++;
	    if (contador % (i * j) == 0) multiplos++;
	}
    printf("\nMultiplos apenas de I: %d", multiplosI);
    printf("\nMultiplos apenas de J: %d", multiplosJ);
    printf("\nMultiplos apenas de ambos: %d", multiplos);
}

//https://pt.stackoverflow.com/q/442052/101
