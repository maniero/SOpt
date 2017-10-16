#include <stdio.h>

int somarpar(int vet[], int n) {
    return n > 0  ? somarpar(vet, n - 1) + (vet[n] % 2 == 0 ? vet[n] : 0) : 0;
}

int main(void) {   
    int vetor[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    printf("a soma dos numeros pares eh: %i\n", somarpar(vetor, 10));
}

//https://pt.stackoverflow.com/q/246494/101
