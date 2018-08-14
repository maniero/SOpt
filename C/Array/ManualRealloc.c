#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
    int indice = 0, indiceParcial = 0;
    int *vetor = malloc(sizeof(int) * 10);
    while (1) {
        int valor;
        scanf("%d", &valor);
        if (valor == 0) break;
        vetor[indice++] = valor;
        if (indiceParcial++ == 9) {
        	int *vetorAuxiliar = malloc(sizeof(int) * (indice + 10));
            memcpy(vetorAuxiliar, vetor, indice * sizeof(int));
            free(vetor);
            vetor = vetorAuxiliar;
            indiceParcial = 0;
        }
    }
    printf("\n");
    for (int i = 0; i < indice; i++) printf("%d  ", vetor[i]);
}

//https://pt.stackoverflow.com/q/322292/101
