#include <stdio.h>
#include <stdlib.h>

int main() {
    float *vet = malloc(sizeof(float) * 10);
    for (int i = 0; i < 10; i++) {
        printf("\nDigite um valor: ");
        scanf("%f", &vet[i]);
        printf("%f", vet[i]);
    }
}

//https://pt.stackoverflow.com/q/105109/101
