#include <stdio.h>

typedef struct {
    int numero;
    char nome[100];
    char morada[100];
    int idade;
    int telefone; //o tipo está errado
} Aluno;

void infoPerson(Aluno *turma, int limite) {
    for (int i = 0; i < limite; i++) {
        printf("Introduza o número \n");
        scanf(" %d", &turma[i].numero);
        printf("Introduza a idade \n");
        scanf(" %d", &turma[i].idade);
        printf("Introduza o telefone \n");
        scanf(" %d", &turma[i].telefone);
        printf("Introduza o nome \n");
        scanf(" %99s", turma[i].nome);
        printf("Introduza a morada \n");
        scanf(" %99s", turma[i].morada);
    }
}

int main() {
    int opc;
    Aluno turma[2];
    do {
        printf("1 - Introduzir alunos\n");
        printf("2 - Teste\n");
        printf("3 - Teste\n");
        scanf("%d", &opc);
        switch (opc) {
            case 1:
                infoPerson(turma, 2);
                break;
            case 2:
                printf("\n");
                break;
            case 3:
                printf("\n");
                break;
        }
    } while (opc < 0 || opc > 3);
    printf("%s - %d\n", turma[0].nome, turma[0].idade);
}

//https://pt.stackoverflow.com/q/276527/101
