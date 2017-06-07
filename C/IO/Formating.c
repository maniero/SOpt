#include <stdio.h>
#define max 10

int main(void) {
	int a[max];
	for (int i = 0; i < max; i++) {
		printf("\nDigite o %i elemento do vetor A: ", i);
		scanf("%d", &a[i]);
	}
	printf("\n");
	for (int i = 0; i < max; i++) {
		printf("%d ", a[i]);
	}
	int par = 0;
	for (int i = 0; i < max; i++) {
		if (a[i] % 2 == 0) {
			printf("\nPar: %d", a[i]);
			par++;	
		}
	}
	printf("\nQuantidade de pares: %d", par);		
}

//https://pt.stackoverflow.com/q/210531/101
