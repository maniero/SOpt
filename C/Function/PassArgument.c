#include <stdio.h>

typedef struct {
    char nome[31];
    char profissao[31];
    int  idade;
    int ativado;
} Pessoa;

void cadastrar(Pessoa pessoas[3]) {
    int op;
    int i = 0;
    do {
        printf("\nNome: ");
        fgets(pessoas[i].nome, sizeof(pessoas[i].nome), stdin);
        printf("\nProfissão: ");
        fgets(pessoas[i].profissao, sizeof(pessoas[i].profissao), stdin);
        printf("\nIdade: ");
        scanf("%d", &pessoas[i].idade);
        printf("\n1 - Continuar\n0 - para sair\n");
        printf("Digite sua escolha: ");
        scanf("%d", &op);
        i++;
    } while (i < 3 && op != 0);
}

int main() {
    Pessoa pessoas[3];
    int op;
    do {
        printf("\nPara cadastrar pessoas aperte 1\n");
        scanf("%d", &op);
        switch (op) {
        case 1:
            cadastrar(pessoas);
            break;
        }
    } while (op != 0);
}

//https://pt.stackoverflow.com/q/340722/101
