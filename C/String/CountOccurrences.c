#include <stdio.h>
#include <string.h>

int main () {
	char padrao[52], mensagem[52];
	printf("Digite uma palavra:");
	fgets(mensagem, 51, stdin);
	printf("Digite o padrao a ser encontrado:");
	scanf("%s", padrao);
	printf("Palavra digitada: %s", mensagem);
	printf("Padrao digitado: %s", padrao);
	int aux = 0;
	char *tmp = mensagem;
	while ((tmp = strstr(tmp, padrao))) {
		aux++;
		tmp++;
	}
    if (aux > 0) printf("****Padrao encontrado %d vezes!****", aux);
    else printf("****Padrao nao encontrado!****");
}

//https://pt.stackoverflow.com/q/387420/101
