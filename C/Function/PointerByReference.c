#include <stdio.h>
#include <stdlib.h>

typedef struct Node {
    int num;
    struct Node *prox;
} Node;

void imprime(Node *lista) {
    Node *tmp = lista;
    while (tmp != NULL) {
        printf("%d\n", tmp->num);
        tmp = tmp->prox;
    }
}

void insere(Node **lista, int val) {
    Node *node = malloc(sizeof(Node));
    node->num = val;
    node->prox = NULL;
    if (*lista == NULL) {
        *lista = node;
    } else {
        Node *atual = *lista;
        while (atual->prox != NULL) {
            atual = atual->prox;
        }
        atual->prox = node;
    }
}

int main(void) {
    Node *lista = NULL;
    insere(&lista, 10);
    insere(&lista, 20);
    insere(&lista, 5);
    imprime(lista);
}

//http://pt.stackoverflow.com/q/187004/101
