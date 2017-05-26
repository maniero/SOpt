#include <stdio.h>

int main(void) {
	char nome[3][30];
	float valorPaciente[3];
	printf ("Particular:\n");
	printf("O valor da consulta e de R$ 450,00: \n");
	float valorTotal = 0;
	int i;
	for (i = 0; i < 3; i++)	{
	    printf("Digite o nome do paciente:");
	    scanf("%30s", nome[i]);
	    valorPaciente[i] = 450.00;
	    valorTotal += valorPaciente[i];
	}
	int qtdPaciente = i - 1; //precisa disto mes mo?
	printf("A quantidade de pacientes particulas foi: %i \n", qtdPaciente);
	printf("o valor total de hoje foi: %.2f\n", valorTotal);
}

//https://pt.stackoverflow.com/q/207789/101
