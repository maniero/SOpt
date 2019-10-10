#include <stdio.h>

int main() {
	char resp;
	do {
	int cont = 1, tinss;
	char s, nome[50];
	float sal, novosala, val;
	printf("\n digite o nome do funcionario; ");
		scanf("%s",&nome);
		printf("\n digite o salario do funcionario: ");
		scanf("%f",&sal);
		if (sal <= 500)	{
			novosala = sal - ((sal / 100) * 8);
			val = (sal / 100) * 8;
			tinss = 8;				
		} else if (sal > 500 &&  sal <= 1000) {
			novosala = sal - ((sal / 100) * 10);
			val = (sal / 100) * 10;
			tinss = 10;	
		} else if (sal > 1000) {
			novosala = sal - ((sal / 100) * 12);
			val = (sal / 100) * 12;
			tinss = 12;
		}
		printf("\n Nome: %s \n",nome);
		printf("\n Salario bruto: %f \n", sal);
		printf("\n Taxa de INSS: %d% \n", tinss);
		printf("\n Valor de INSS %f \n", val);
		printf("\n Salario liquido: %f \n", novosala);
		printf("\n deseja continuar ? \n");
		scanf("%s",&resp);
		cont = cont + 1;
	} while (resp == 's');
}

//https://pt.stackoverflow.com/q/87784/101
