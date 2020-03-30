#include <stdio.h>
#include <stdlib.h>

#define MAX 10

typedef struct pilha {
    int qnt;
    int dados[MAX];
} Pilha;
Pilha* cria() {
    Pilha *p = malloc(sizeof(Pilha));
    if (p != NULL) p->qnt = 0;
    return p;
}
void insere(Pilha *p, int valor) {
    p->dados[p->qnt] = valor;
    p->qnt++;
}
void exibe(Pilha *p) {
    for (int i = 0; i < p->qnt; i++) printf("%3d", p->dados[i]);
}
Pilha* inverte(Pilha *p) {
    Pilha *outra = cria();
    while (p->qnt > 0) {
        outra->dados[outra->qnt] = p->dados[p->qnt - 1];
        p->qnt--;
        outra->qnt++;
    }
    return outra;
}
int main() {
    Pilha *p = cria();
    insere(p, 32);
    insere(p, 45);
    insere(p, 78);
    exibe(p);
    p = inverte(p);
    printf("\n");
    exibe(p);
}

//https://pt.stackoverflow.com/q/171352/101
