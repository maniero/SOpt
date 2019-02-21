#include <stdio.h>

typedef struct {
    int id;
    char nome[201];
    char endereco[101];
    char cidade [31];
} Pessoa;

void preencherPessoas(Pessoa pessoas[], int qtde) {
	for (int i = 0; i < qtde; i++) {
		printf(" Digite o ID do funcionário: ");
		scanf("%d", &pessoas[i].id);
		printf(" Digite a nome do funcionário: ");
		scanf("%s", pessoas[i].nome);
		printf(" Digite o endereco do funcionário: ");
		scanf("%s", pessoas[i].endereco);
		printf(" Digite o cidade do funcionário: ");
		scanf("%s", pessoas[i].cidade);
		printf(" DADOS DO FUNCIONARIO DE ID %d CADASTRADOS! \n", pessoas[i].id);
	}
}

int main() {
	printf("Insira a quantidade de funcionários que serão cadastrados: ");
	int qtde;
	scanf("%d", &qtde);
    printf("\nQTD: %d", qtde);
	Pessoa pessoas[qtde];
	preencherPessoas(pessoas, qtde);
}

//https://pt.stackoverflow.com/q/363861/101
