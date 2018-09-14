#include <stdio.h>

int main(void) {
	int max = 30;
	printf("\n| %*s | %8s | %8s |", max, "Nome", "Salario", "Idade");
	printf("\n| %.*s | %8s | %8s |", max, "Nome", "Salario", "Idade");
	max = 3;
	printf("\n| %*s | %8s | %8s |", max, "Nome", "Salario", "Idade");
	printf("\n| %.*s | %8s | %8s |", max, "Nome", "Salario", "Idade");
}

//https://pt.stackoverflow.com/q/39389/101
