#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	//Variáveis
	double numero_horas_trabalhadas;
	double salarioMinimo;
	double numero_horas_extras;
	double valor_hora, valor_hora_extra, salarioBruto, salarioTotal;
	//Entrada de dados
	printf("Olá, vamos calcular o seu salário!");
	printf("\nDigite as horas trabalhadas: ");
	scanf("%lf",&numero_horas_trabalhadas);
	printf("\nDigite o valor do salario minimo: ");
	scanf("%lf",&salarioMinimo);
	printf("\nDigite o numero de horas extras trabalhadas: ");
	scanf("%lf",&numero_horas_extras);
	//Processamento
	valor_hora = salarioMinimo/8;
	valor_hora_extra = salarioMinimo/4;
	salarioBruto = (numero_horas_trabalhadas * valor_hora);
	valor_hora_extra = (numero_horas_trabalhadas * valor_hora_extra);
	salarioTotal = salarioBruto + valor_hora_extra;
	//Saída de informação
	printf ("O valor do salario minimo e : %f",salarioTotal);
}

//https://pt.stackoverflow.com/q/57946/101
