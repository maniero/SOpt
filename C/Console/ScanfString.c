#include <stdio.h>
#include <string.h>

int main() {
	float altura, peso;
	char sexo[10];
	printf("Digite sua altura\n");
	scanf("%f", &altura);
	printf("Digite seu peso\n");
	scanf("%f", &peso);
	printf("Digite seu sexo\n");
	scanf("%9s", sexo);
	if (!strcmp(sexo, "masculino")) printf("Peso Ideal:%f\n", (72.7 * altura) - 58);
}

//https://pt.stackoverflow.com/q/338080/101
