#include <stdio.h>
typedef struct peca {
	int lado1;
	int lado2;
} peca;
int main() {
	int d = 0;
	int e = 0;
	printf("digite um lado da peca: ");
	scanf("%i", &d);
	printf("digite outro lado da peca: ");
	scanf("%i", &e);
	peca peca1 = { d, e };
	printf("\n%i, %i", peca1.lado1, peca1.lado2);
	int peca[] = { d, e };
	printf("\n%i, %i", peca[0], peca[1]);
}

//https://pt.stackoverflow.com/q/128197/101
