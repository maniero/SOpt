#include<stdio.h>
#include<string.h>

int main() {
	int peso, altura, idade, necessidadeCal, atividadeInd;
	char sexo[10], atividadeLvl[30];
	printf("Insira seu peso: ");
	scanf("%d", &peso);
	printf("\nInsira sua altura: ");
	scanf("%d", &altura);
	printf("\nInsira sua idade: ");
	scanf("%d", &idade);
	printf("\nInsira seu sexo: ");
	scanf("%s", sexo);
	printf ("\nEm relacao a atividades fisicas, voce se considera: sedentario, levemente ativo, moderadamente ativo, muito ativo ou extremamente ativo? "); 
	scanf ("%s", atividadeLvl);
	if  (strcmp(atividadeLvl, "sedentario")) {
	    atividadeInd = 1.25;
	} else if (strcmp(atividadeLvl, "levemente ativo")) {
	    atividadeInd = 1.30;
	} else if (strcmp(atividadeLvl, "moderadamente ativo")) {
	    atividadeInd = 1.50;
	} else if (strcmp(atividadeLvl, "muito ativo")) {
	    atividadeInd = 1.70;
	}  else if (strcmp(atividadeLvl, "extremamente ativo")) {
	    atividadeInd = 2.00;
	}
	if (strcmp(sexo, "masculino")) {
	    peso = 66 + 13.7 * peso;
	    altura *= 5;
	    idade *= 6.8;
	} else if (strcmp(sexo, "feminino")) {
	    peso = 655 + 9.6 * peso;
	    altura *= 1.7;
	    idade *= 4.7;
	}
	necessidadeCal = (peso + altura - idade) * atividadeInd;
	printf ("\nO seu consumo ideal e de %d calorias diarias", necessidadeCal);
}

//https://pt.stackoverflow.com/q/171109/101
