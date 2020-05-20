#include <stdio.h>
#include <stdlib.h>

typedef struct {
    char *nome;
    char *numero;

} Agenda;

void adiciona(Agenda* reg, int i) {
    reg[i].nome = malloc(30);
    reg[i].numero = malloc(6);
    scanf("%s", reg[i].nome);
    scanf("%s", reg[i].numero);
}

void imprime(Agenda* reg, int i) {
    for (int j = 0; j < i; j++) {
        printf("Nome: %s | ", reg[j].nome);
        printf("Numero: %s\n", reg[j].numero);
    }
}

int main() {
    int sair = 0;
    int i = 0;
    Agenda registro[10];
    while (!sair) {
        int escolha;
        printf("O que voce deseja ? (1)Inserir (2)Imprimir (3)Sair\n");
        scanf("%d", &escolha);
        switch(escolha) {       
            case 1:
                adiciona(registro, i);
                i++;
                break;
            case 2:
                imprime(registro, i);
                break;
            case 3:
                sair = 1;
                break;
        } 
    }
}

//https://pt.stackoverflow.com/q/209878/101
