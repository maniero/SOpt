#include <stdio.h>

int main(void) {
	int contador = 0, soma = 0;
    while (contador < 4) {
    	int numero;
        printf("Digite o número: ");
        scanf("%d", &numero);
        contador++;
        soma += numero;
    }
	printf("A soma entre os valores digitados é de: %d", soma);
}

//https://pt.stackoverflow.com/q/410715/101
