#include <stdio.h>
#include <malloc.h>

#define MAX 50

typedef struct {
    char numero[12]; //permite um telefone nacional
    char nome[31]; //permite 30 caracteres
} Entrada;

typedef struct {
    int tamanho;
    Entrada *contatos;
} Agenda;



void cadastrar(Agenda *agenda) {
    int op = 1;
    do {
        printf("Digite o telefone\n");
        scanf("%11s", agenda->contatos[agenda->tamanho].numero);
        printf("Digite o seu nome\n");
        scanf(" %30[^\n]", agenda->contatos[agenda->tamanho].nome);
        printf("Digite 1 para continuar 2 para parar\n");
        scanf("%d", &op);
        agenda->tamanho++;
    } while (op != 2);
}

void imprime(Agenda agenda) {
    for (int i = 0; i < agenda.tamanho; i++) printf("%11s - %s\n", agenda.contatos[i].numero, agenda.contatos[i].nome);
}

Agenda iniciaAlocaAgenda() {
    return (Agenda) { .tamanho = 0, .contatos = malloc(sizeof(Entrada) * MAX) };

}

void liberaAgenda(Agenda agenda) {
    free(agenda.contatos);
}


int main() {
    Agenda agenda = iniciaAlocaAgenda();
    int op = 1;
    do {
        printf("1-Adicionar numero\n");
        printf("2-Remover numero\n");
        printf("3-Procurar numero\n");
        printf("4-Imprimir\n");
        printf("6-Reincia a agenda\n");
        printf("7-Parar\n");
        scanf("%d", &op);
        switch (op) {
        case 1:
            cadastrar(&agenda);
            break;
        case 2:
        case 3:
            break;
        case 4:
            imprime(agenda);
            break;
        case 5:
            break;
        case 6:
            agenda = iniciaAlocaAgenda();
            break;
        }
    } while (op != 7);
    liberaAgenda(agenda);
}

//https://pt.stackoverflow.com/q/310814/101
