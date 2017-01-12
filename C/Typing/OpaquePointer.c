#include <stdio.h>

typedef struct { int x; } MinhaEstrutura;

typedef MinhaEstrutura * MeuTipo;

int main(void) {
	MinhaEstrutura dado = { 1 };
	MeuTipo var = &dado; //teve que usar o operador para pegar o endereço
	printf("%d", var->x); //teve que usar -> para acessar o membro
}

//http://pt.stackoverflow.com/a/176939/101
