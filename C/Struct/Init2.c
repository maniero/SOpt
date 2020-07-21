#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#define tam 100

typedef struct {
    char *nome;
    char *curso;
    char *cota;
    int matricula;
    int coef;
} TipoAluno;

int main() {
    TipoAluno aluno = {
        .nome = malloc(2),
        .curso = malloc(2),
        .cota = malloc(2),
        .matricula = 1
    };
    strcpy(aluno.nome, "A");
    strcpy(aluno.curso, "B");
    strcpy(aluno.cota, "C");
    printf("%s", aluno.nome);
}

//https://pt.stackoverflow.com/q/303898/101
