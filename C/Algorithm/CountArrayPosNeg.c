#include <stdio.h>

int main(void) {
	int pos[3], neg[3], posCount = 0, negCount = 0;
	for (int i = 0; i < 3; i++) {
		int valor;
	    printf("Informe um valor: ");
	    scanf("%d", &valor);
	    if (valor < 0) neg[negCount++] = valor;
	    else pos[posCount++] = valor;
	}
	printf("Os números positivos digitados foram: ");
	for (int i = 0; i < posCount; i++) printf("%d ", pos[i]);
	printf("\nOs números negativos digitados foram: ");
	for (int i = 0; i < negCount; i++) printf("%d ", neg[i]);
}

//https://pt.stackoverflow.com/q/318502/101
