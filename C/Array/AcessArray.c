#include <stdio.h>

#define TAM 5

int main(void) {
    struct {
        int cod;
        char nome_da_obra[41];
        char nome_do_autor[41];
        char nome_da_editora[41];
    } livro[TAM];
    for (int i = 0; i < TAM; i++) {
        printf("\n---------- Cadastro dos Livros -----------\n");
        livro[i].cod = i;
        printf("Insira o nome da Obra: ");
        fgets(livro[i].nome_da_obra, 40, stdin);
        printf("Insira o nome do autor: ");
        fgets(livro[i].nome_do_autor, 40, stdin);
        printf("Insira o nome da Editora: ");
        fgets(livro[i].nome_da_editora, 40, stdin);
    }
}

//https://pt.stackoverflow.com/q/394438/101
