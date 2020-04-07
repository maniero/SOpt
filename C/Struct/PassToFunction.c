#include <stdio.h>
#include <stdlib.h>

#define NUM_NOTAS 5
#define TAM_NOME 20

struct Aluno {
 char nome[TAM_NOME];
 int numero;
 int notas[NUM_NOTAS];
};

void preenche(struct Aluno lista[], int tam) {
	for (int i = 0; i < tam; i++) {
	    printf("\nNome:");
	    scanf("%s", lista[i].nome);
	    printf("\nNúmero:");
	    scanf("%d", &lista[i].numero);
	    for (int j = 0; j < NUM_NOTAS; j++) {
	        printf("\nIntroduza a nota %d:", j);
	        scanf("%d", &lista[i].notas[j]);
	    }
	}
}

int main(void) {
    struct Aluno lista[2];
    preenche(lista, 2);
    printf("\n----------------------");
	for (int i = 0; i < 2; i++) {
	    printf("\nNome:");
	    printf("%s", lista[i].nome);
	    printf("\nNúmero:");
	    printf("%d", lista[i].numero);
	    for (int j = 0; j < NUM_NOTAS; j++) {
	        printf("\nNota %d:", j);
	        printf("%d", lista[i].notas[j]);
	    }
	}
    return (EXIT_SUCCESS);
}

//https://pt.stackoverflow.com/q/175156/101
