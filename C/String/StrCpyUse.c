#include <string.h>
#include <stdio.h>

typedef struct {
    char nome[81];
    char ano[5];
    char diretor[81];
} Filme;

void analise(Filme *filme, const char *arg1, const char *arg2, const char *arg3) {
    strcpy(filme->nome, arg1);
    strcpy(filme->ano, arg2);
    strcpy(filme->diretor, arg3);
}

void carregar(Filme filmes[]) {
    analise(&filmes[0], "E o Vento Levou", "1939", "Victor");
    analise(&filmes[1], "teste", "998", "bar");
    analise(&filmes[2], "Os Passaros", "1963", "Alfred Hitchcock");
}

int main() {
    Filme filmes[1000];
    carregar(filmes);
    printf("\nmain:\n");
    for (int i = 0; i < 3; i++) {
        printf("- Nome:    %s\n", filmes[i].nome);
        printf("- Ano:     %s\n", filmes[i].ano);
        printf("- Diretor: %s\n", filmes[i].diretor);
        printf("----------------\n");
    }
}

//https://pt.stackoverflow.com/q/303948/101
