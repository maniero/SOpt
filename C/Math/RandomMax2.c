#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define LIMITE 1000

int myrand() {
    int r = 0;
    for (int i = 0; i < 2; i++) r = (r << 15) | (rand() & 0x7FFF);
    return r & 0xFFFFFFFF;
}

int main() {
	int vet[LIMITE];
    srand((unsigned)time(NULL));
    for (int x = 0 ; x < LIMITE; x++) vet[x] = myrand();
    for (int x = 0; x < LIMITE; x++) {
        for (int y = x + 1; y < LIMITE; y++) {
            if (vet[x] > vet[y]) {
                int aux = vet[x];
                vet[x] = vet[y];
                vet[y] = aux;
            }
        }
    }
    printf("\nVetor ordenado (ou nao): \n\n");
    for (int x = 0; x < LIMITE; x++) printf("Numero %d: %d\n", x + 1, vet[x]);
}

//https://pt.stackoverflow.com/q/151846/101
