#include<stdio.h>
#include<string.h>
#define tam 100

typedef struct {
    char nome[51];
    char curso[51];
    char cota[51];
    int matricula;
    int coef;
} TipoAluno;

int main() {
	TipoAluno aluno = {
		.nome = "A",
		.curso = "B",
		.cota = "C",
		.matricula = 1
	};
	printf("%s", aluno.nome);
}

//https://pt.stackoverflow.com/q/303898/101
