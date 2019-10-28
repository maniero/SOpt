#include <stdio.h>
#define MAX 10

int main(void) {
    int vetor [MAX] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int *ptr_vetor;
    int novo_vetor[MAX];
    int *ptr_novo_vetor;
    ptr_vetor = &vetor[0];
	printf("\n--- Vetor ---");
    for (int i = 0; i < MAX; i++) printf("\nvalor : %d ", vetor[i]);
	printf("\n\n--- Ponteiro Vetor para Numero Pares ---");
    for (int i = 0; i < MAX; i++) {
        if (ptr_vetor[i] % 2 == 0) {
            printf("\nNumero Par : %d ", ptr_vetor[i]);
            novo_vetor[i / 2] = ptr_vetor[i];
        }
    }
    ptr_novo_vetor = novo_vetor;
	printf("\n\n\n--- Novo Vetor ---");
    for (int i = 0; i < MAX / 2; i++) printf("\nvalor: %d ", novo_vetor[i]);
	printf("\n\n--- Ponteiro Novo Vetor ---");
    for (int i = 0; i < MAX / 2; i++) printf("\nNovo Vetor : %d ", *(ptr_novo_vetor+i));
}

//https://pt.stackoverflow.com/q/97857/101
