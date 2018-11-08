#include <stdio.h>

int main() {
    int variavelA = 0;
    printf("Digite um número maior que zero: ");
	while (!scanf("%d", &variavelA) || !variavelA) {
    	printf("Digite um número maior que zero: ");
    	getchar();
    }
    printf("%d", variavelA);
}

//https://pt.stackoverflow.com/q/341604/101
