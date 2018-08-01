#include <stdio.h>
#include <stdlib.h>

int main() {
	int tam;
    printf("Tamanho do vetor: ");
    scanf("%d", &tam);
    int *vet = malloc(tam * sizeof(int));
    
    printf("\nEntre com os elementos do vetor:\n");
    for (int i = 0; i < tam; i++) scanf("%d", &vet[i]);
    printf("Elementos do vetor:\n");
    for (int i = 0; i < tam; i++) printf("%d ", vet[i]);
}

//https://pt.stackoverflow.com/q/318510/101
