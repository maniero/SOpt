#include<stdio.h>
#include<stdlib.h>

int main() {   
	struct calendario {
		int dia;
		int mes;
		int ano;
	};
	struct calendario *ptr = malloc(sizeof(struct calendario));
	ptr->dia = 5;
	ptr->mes = 10;
	ptr->ano = 1990;
	printf("%i/%i/%i", ptr->dia, ptr->mes, ptr->ano);
}

//https://pt.stackoverflow.com/q/126779/101
