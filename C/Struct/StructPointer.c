#include <stdio.h>
#include <stdlib.h>
typedef struct node {
	int categoria;
	int atributoOuDecisao;
	struct node *prox;
	struct node *lista;
} No;

No *criaArvore(void){
    No *inicio = malloc(sizeof(No));
 	inicio->atributoOuDecisao = 0;
 	inicio->categoria = 0;
 	inicio->lista = NULL;
  	inicio->prox = NULL;
  	printf ("inicio criado");
   	return inicio;
}

int main() {
	criaArvore();
}

//https://pt.stackoverflow.com/q/159173/101
