#include <stdio.h>
#include <locale.h>
#include <string.h>

int main(void) {
	setlocale(LC_ALL, "Portuguese");
	int escolha;
	char sexo[11];
	printf("Escolha uma das opções abaixo: ");
	printf("\n1- Sou mulher ");
	printf("\n2- Sou homem ");
	scanf("%d", &escolha);
	if (escolha == 1) strcpy(sexo, "Feminino");
	else strcpy(sexo, "Masculino");
	printf("Você é do sexo: %s", sexo);
}

//https://pt.stackoverflow.com/q/247686/101
