#include <stdio.h>
#include <stdlib.h>

#define MAX 3

typedef struct alunos {
    int matricula;
    char nome[30];
    float nota1, nota2;
} Alunos;

typedef struct lista {
    int quant;
    Alunos dados[MAX];

} Lista;

Lista* cria_Lista() {
    Lista* l = malloc(sizeof(Lista));
    if (l != NULL) l->quant = 0;
    return l;
}

void libera_Lista(Lista* l) {
    free(l);
}

int insere_final(Lista* l, Alunos al) {
    if (l == NULL) { // || lista_Cheia(l)) { --- tirei porque a função não existe
        return 0;
    }
    l->dados[l->quant] = al;
    l->quant++;
    return 1;
}

int insere_inicio(Lista *l, Alunos al) {
    if (l == NULL) { // || lista_Cheia(l)) { --- tirei porque a função não existe
        return 0;
    }
    for (int i = l->quant - 1; i >= 0; i--) {
    printf("ok");
        l->dados[i + 1] = l->dados[i];
        l->dados[0] = al;
        l->quant++;
    }
    l->dados[0] = al;
    l->quant++;
    return 1;
}

void imprime_lista(Lista* l) {
    if (l == NULL) return;
    for(int i = 0; i < l->quant; i++) {
        printf("Matricula: %d\n", l->dados[i].matricula);
        printf("Nome: %s\n", l->dados[i].nome);
        printf("Notas: %f %f\n", l->dados[i].nota1, l->dados[i].nota2);
    }
}

int main() {
    Alunos al[2] = {{3, "João", 8.45, 9.98}, {1, "Maria", 6.75, 8.54}};
    Lista *l = cria_Lista();
    for (int i = 0; i < 2; i++) {
        insere_inicio(l, al[i]);
        imprime_lista(l);
    }
    libera_Lista(l);
}

//https://pt.stackoverflow.com/q/157781/101
