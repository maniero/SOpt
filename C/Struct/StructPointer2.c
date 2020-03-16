#include <stdio.h>
#include <stdlib.h>

typedef struct node {
    int categoria;
    int atributoOuDecisao;
    struct node *prox;
    struct node *lista;
} No;

No *criaArvore(void) {
    No *inicio = malloc(sizeof(No));
    inicio->atributoOuDecisao = 0;
    inicio->categoria = 99;
    inicio->lista = NULL;
    inicio->prox = NULL;
    return inicio;
}

No *criaFilho(No *pai, int atributoDoPai, int categoriaDoFilho, int atributoOuDecisao) {
    No *p1 = malloc(sizeof(No));
    p1->atributoOuDecisao = atributoOuDecisao;
    p1->categoria = categoriaDoFilho;
    p1->lista = NULL;
    p1->prox = NULL;
    if (pai->lista == NULL) {
        pai->lista = p1;
    } else {
        No *aux = pai->lista;
        while (aux->prox != NULL) aux = aux->prox;
        pai->prox = p1;
    }
    return p1;
}

int main() {
    No *arv = criaArvore();
    No *aux = criaFilho(arv, 1, 1, 3);
    criaFilho(aux, 3, 0, 1);
}

//https://pt.stackoverflow.com/q/159198/101
