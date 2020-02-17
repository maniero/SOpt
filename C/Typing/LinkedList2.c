#include <stdio.h>
#include <stdlib.h>

struct lista {
	int info;
	struct lista* prox;
};

typedef struct lista Lista;

Lista* list_new(void) {
	return (Lista*)NULL;
}

Lista* list_add(Lista* l, int i) {
	Lista* novo = malloc(sizeof(Lista));
	novo -> info = i;
	novo -> prox = l;
	return novo;
}

void list_print(Lista* l) {
	do {
		printf("%d\t",l->info);
		l = l->prox;
	} while (l != NULL); 
}

int main(void) {
	Lista* l = list_new();
	l = list_add(l, 23);
	l = list_add(l, 45);
	list_print(l); 
}

//https://pt.stackoverflow.com/q/147434/101
