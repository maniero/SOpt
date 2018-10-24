#include <stdio.h>

int main () {
	int opcao;
	printf("Bem Vindo ! \n O que deseja fazer ? \n 1 - Se cadastrar \n 2 - Reservar um lugar \n");
	scanf("%d", &opcao);
	if (opcao == 1) {
		int tipoPessoa;
		printf("Você é: \n 1 - Professor \n 2 - Aluno \n 3 - Convidado \n 4 - Portador de necessidade especial \n");
		scanf("%d", &tipoPessoa);
		switch(tipoPessoa) {
			case 1: {
				char nomePessoa[31], rgPessoa[10], emailPessoa[65];
				printf("Informe seu nome completo: ");
				scanf("%30s", nomePessoa);
				printf("Informe seu RG: ");
				scanf("%9s", rgPessoa);
				printf("Informe seu E-mail: ");
				scanf("%64s", emailPessoa);
			}
		}		
	}
}

//https://pt.stackoverflow.com/q/337905/101
