#include <stdio.h>
#include <string.h>
#define TURMAS 2
#define ALUNOS 10

int main() {
    char nomes[ALUNOS][TURMAS][31];
    for (int j = 0; j < TURMAS; j++) {
        printf("\nTurma %d:\n", j + 1);
        for (int i = 0; i < ALUNOS; i++) {
            printf("Aluno: ");
            scanf("%30s", nomes[i][j]);
        }
    }
    printf("\nTurma 1:                      Turma 2:\n");
    for (int i = 0; i < ALUNOS; i++) {
    	printf("%s", nomes[i][0]);
        for (int j = 1; j < TURMAS; j++) printf("%30s", nomes[i][j]);
        printf("\n");
    }
}

//https://pt.stackoverflow.com/q/500054/101
