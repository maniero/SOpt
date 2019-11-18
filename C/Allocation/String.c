#include<stdio.h>
#include<stdlib.h>
#define TAM 3

void imprime(char *v1[TAM], int v2[TAM]) {
    for (int i = 0; i < TAM; i++) printf("Nome:%s\nAltura:%d\n", v1[i], v2[i]);
}
int main() {
    char **vet1 = malloc(TAM + 1);
    int *vet2 = malloc(TAM * sizeof(int));
    for (int i = 0; i < TAM; i++) {
        printf("Nome %d de altura %d\n", i, i);
        vet1[i] = malloc(21);
        scanf("%20s", vet1[i]);
        scanf("%d", &vet2[i]);
    }
    imprime(vet1, vet2);
    for (int i = 0; i < TAM; i++) free(vet1[i]);
    free(vet1);
    free(vet2);
}

//https://pt.stackoverflow.com/q/421664/101
