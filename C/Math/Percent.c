#include <stdio.h>

int main() {
	float salario;
	printf("Digite o salario: ");
	scanf("%f", &salario);
	salario *= 0.98;
	printf("\nO salario com desconto: %4.2f", salario);
}

//https://pt.stackoverflow.com/q/126678/101
