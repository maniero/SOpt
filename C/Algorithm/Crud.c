#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct aluno {
    int matricula;
    char nome[50];
    char curso[20];
} Aluno;

Aluno *novo(int matricula, char *nome, char *curso) {
    Aluno *a = malloc(sizeof(Aluno));
    a->matricula=matricula;
    strcpy(a->nome, nome);
    strcpy(a->curso, curso);
    return a;
}

void libera(Aluno *aluno) {
    free(aluno);
}

void acessa(Aluno *aluno, int *matricula, char *nome, char *curso) {
    *matricula = aluno->matricula;
    strcpy(nome, aluno->nome);
    strcpy(curso, aluno->curso);
}

void atribui(Aluno *aluno, int matricula, char *nome, char *curso) {
    aluno->matricula = matricula;
    strcpy(aluno->nome, nome);
    strcpy(aluno->curso, curso);
}

int size() {
    return (int)sizeof(Aluno);
}

int main() {
    Aluno *a = novo(123, "victhor", "computacao");
    int matricula;
    char nome[50], curso[20];
    acessa(a , &matricula, nome, curso);
    printf("Matrícula: %d\n", matricula);
    printf("Nome: %s\n", nome);
    printf("Curso: %s\n", curso);
}

//https://pt.stackoverflow.com/q/163521/101
