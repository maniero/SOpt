#include <stdio.h>
#include <stdlib.h>

typedef struct no {
    int info;
    struct no *esq;
    struct no *dir;
} Node;

Node *insere(Node *arv, int valor) {
    if (arv == NULL) {
        arv = malloc(sizeof(Node));
        arv->info = valor;
        arv->esq = NULL;
        arv->dir = NULL;
        return arv;
    } else if (valor > arv->info) {
        arv->dir = insere(arv->dir, valor);
        return arv->dir;
    } else {
        arv->esq = insere(arv->esq, valor);
        return arv->esq;
    }
}

void imprime (Node *arv) { 
    if (arv != NULL) {
        imprime(arv->esq);
        printf("\n %d", arv->info);
        imprime(arv->dir);
    }
}

int main (void) {
    Node *arv = malloc(sizeof(Node));
    arv->info = 1;
    arv->dir = NULL;
    arv->esq = NULL;
    insere(arv, 2);
    insere(arv, 3);
    imprime(arv);
}

//http://pt.stackoverflow.com/q/190689/101
