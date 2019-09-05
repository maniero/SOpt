#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main() {
	int decimal;
	printf("Digite um nÃºmero em base decimal: ");
	scanf("%d", &decimal);
	int counter = 1;
	char *binary = NULL;
	while (decimal >= 1) {
		int q = decimal / 2;
		int r = decimal - (q * 2);
		char *aux = malloc(counter);
		if (binary != NULL) {
			memcpy(aux, binary, counter - 1);
			free(binary);
		}
		binary = aux;
		if (r == 0) binary[counter-1] = '0';
		else binary[counter-1] = '1';
		counter++;
		decimal = q;
	}
	printf("Resultado em binÃ¡rio = ");
	for (int i = counter - 1; i >= 0; i--) printf("%c", binary[i]);
	printf("\n");
	free(binary);
}

//https://pt.stackoverflow.com/q/58696/101
