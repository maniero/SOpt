#include <stdio.h>
#include <stdlib.h>
#define MAX 30

struct CARRO{
	int id;
	char fabricante[MAX];
	char modelo[MAX];
	int ano;
	char cor[MAX];
	int preco;
};

int main() {
	int qtd;
	scanf("%d", &qtd);
	struct CARRO *carros = malloc(qtd * sizeof(struct CARRO));
	free(carros); //só para usar a variável, neste caso não precisa
}

//https://pt.stackoverflow.com/q/215819/101
