#include <stdio.h>
#include <stdbool.h>

void PrintVetor(int conjunto[], int tamanho) {
	printf("[");
    for (int i = 0; i < tamanho; i++) printf(" %d", conjunto[i]);
    printf(" ]\n");
}

bool Existe(int x, int uniao[], int tamanho) {
    for (int i = 0; i < tamanho; i++) if (uniao[i] == x) return true;
    return false; 
}

int main() {
    int tamanho;
    printf("Qual o tamanho dos conjuntos?\n");
    scanf("%i", &tamanho);
    int conjA[tamanho];
    int conjB[tamanho];
    int uniao[tamanho * 2];
    printf("Preencha o Conjunto A\n");
    for (int i = 0; i < tamanho; i++) {
        scanf("%d", &conjA[i]);
        uniao[i] = conjA[i];
    }
    printf("Preencha o Conjunto B\n");
    for (int i = 0; i < tamanho; i++) scanf("%d", &conjB[i]);
    printf("Conjunto A: ");
    PrintVetor(conjA, tamanho);
    printf("Conjunto B: ");
    PrintVetor(conjB, tamanho);
    for (int i = 0, k = tamanho; i < tamanho; i++, k++) if (!Existe(conjB[i], uniao, k)) uniao[k] = conjB[i];
    printf("Conjunto Uniao: ");
    PrintVetor(uniao, tamanho * 2);
 }
 
 //https://pt.stackoverflow.com/q/343764/101
