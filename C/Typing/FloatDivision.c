#include <stdio.h>

int main(void) {
	float salario; // salário
	float emprestimo; // valor empréstimo
	scanf ("%f %f", &salario, &emprestimo);
    printf("emprestimo%s concedido", emprestimo /salario <= 1.2 ? "" : " nao");
}

//https://pt.stackoverflow.com/q/201412/101
