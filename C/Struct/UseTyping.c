#include <stdio.h> 
#include <stdlib.h>

typedef struct {
    int PosAtual;
    int UltimaPos;
    int *VetAux;
} Lista;

void Inserir(Lista *vet, int pos) {} //mudei aqui

int PosValida() {
    int pos;
    do {
        printf("Informe Posição da Estrutura Principal\n");
        scanf("%d", &pos);
            if (pos < 0 || pos > 10)
                printf("Posição Inválida\n");
    } while (pos < 0 || pos > 10);
    return pos;
}

int menu() {
    int op;
    printf("Digite as opção desejada\n");
    printf("0 - Sair\n");
    printf("1 - Inserir\n");
    scanf("%i", &op);
    return op;
}

int main() {
    Lista lista_principal[10];
    for (int i = 0; i < 10; i++) {
        lista_principal[i].VetAux = NULL;
        lista_principal[i].UltimaPos = 0;
        lista_principal[i].PosAtual = 0;
    }
    int opcao = 1;
    while (opcao) {
        opcao = menu();
        switch (opcao) {
            case 0:
                break;
            case 1:
                Inserir(lista_principal, PosValida());
                break;
            default:
                printf("opcao inválida\n");
        }
    }
}

//https://pt.stackoverflow.com/q/239361/101
