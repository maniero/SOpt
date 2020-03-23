#include <stdio.h>

int main() {
	int soma = 0;
	int contador = 0;
	for (; contador < 3; contador++) {
	    printf("Digite um numero inteiro : ");
	    int numero;
	    scanf("%d", &numero);
	    soma += numero;   
	}
	printf("A media dos numeros e %.2f \n", (float)soma / contador);
}

//https://pt.stackoverflow.com/q/440914/101
