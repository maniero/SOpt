#include <stdio.h>

int main() {
	printf("---Sexo---\n");
	printf("1 - Masculino\n");
	printf("2 - Feminino\n");
	int sexo;
	scanf("%d", &sexo);
	if (sexo != 1 && sexo != 2) printf("\nOpção Inválida\n");
}

//https://pt.stackoverflow.com/q/395835/101
