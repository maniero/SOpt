#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAX 12

typedef struct aluno {
    char nome[40];
    int idade;
} Aluno;

typedef struct lista {
    size_t qnt;
    Aluno dados[MAX];
} Lista;

Lista* cria() {
    Lista *l = malloc(sizeof(Lista));
    if (l != NULL)
        l->qnt = 0;
        return l;
}

int insere(Lista *l, Aluno al) { //insere no inicio
    if (l == NULL || l->qnt == MAX) return 0;
    for (int  i = l->qnt; i > 0; i--) l->dados[i] = l->dados[i - 1];
    memcpy(&l->dados[0], &al, sizeof(Aluno));
    l->qnt++;
    return 1;
}

void liberar(Lista *l) {
    free(l);
}

void exibe(Lista *l) {
    if (l->qnt == 0) printf("\nLista esta vazia.\n\n");
    for (int i = 0; i < l->qnt; i++) {
        printf("Aluno: %s", l->dados[i].nome);
        printf(", de Idade: %d\n", l->dados[i].idade);
    }
}

int main() {
    Lista *l = cria();
    Aluno al;
    int opc;
    do {
        printf("\tEscolha uma Opcao\n");
        printf("O: sair\n");
        printf("1: Cadastrar Aluno\n");
        printf("2: Exibir Alunos\n");
        printf("Opcao: ");
        scanf("%d", &opc);
        switch(opc) {
        case 0:
            break;
        case 1: //inconsistência
            printf("\nDigite o nome: ");
            scanf("%s", al.nome);
            printf("Digite a idade: ");
            scanf("%d", &al.idade);
            insere(l, al);
            system("cls");
            break;
        case 2:
            exibe(l);
            break;
        default:
            printf("Opcao Invalida.\n");
            break;
        }
    } while (opc != 0);
    liberar(l);
}

//https://pt.stackoverflow.com/q/171059/101
