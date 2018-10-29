#include <stdlib.h>
#include <stdio.h>
#include <strings.h>

#define quantidade_filmes 2
#define tamanho_nome 31

typedef struct {
	char nome_filme[tamanho_nome];
	char genero_filme[tamanho_nome];
	int classificacao;
} Dados;

int main() {
	Dados dados[quantidade_filmes];
	for (int i = 0; i < quantidade_filmes; i++) {
		printf("Cadastrando filme de numero %i \n", i + 1);
		printf("Digite o nome do filme:\n");
		scanf("%[^\n]\n", dados[i].nome_filme);
		printf("Qual o genero do %s ?\n", dados[i].nome_filme);
		scanf("%[^\n]\n", dados[i].genero_filme);
		printf("O filme e para maiores de 18 anos? 0-nao 1-sim\n");
		scanf("%d\n", &dados[i].classificacao);
	}
	for (int i = 0; i < quantidade_filmes; i++) {
		printf("NOME: %s\n", dados[i].nome_filme);
		printf("GENERO: %s\n", dados[i].genero_filme);
		if (dados[i].classificacao == 0) printf("FILME DESTINADO AO PUBLICO MAIOR DE 18 ANOS\n\n");
		else printf("FILME LIVRE PARA TODOS OS PUBLICOS\n\n");
	}
}

//https://pt.stackoverflow.com/q/339007/101
