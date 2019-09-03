#include <stdio.h>

int main (void) {
    int troca, vetorA[10];
        for (int i = 0; i < 10; i++) {
        printf("Digite o valor do elemento:");
        scanf("%d", &vetorA[i]);
    }
    for (int i = 0; i < 10; i++) { // <=========== Aqui tinha um j < 10 que obviamente causa confusão
        for (int j = i + 1; j < 10; j++) {  
            if (vetorA[i] > vetorA[j]) {
                troca = vetorA[i];
                vetorA[i] = vetorA[j];
                vetorA[j] = troca;
             }
        }
    }
    printf("\nvetor ordenado\n");
    for (int i = 0; i < 10; i++) {
        printf("%d - ", vetorA[i]);
    }
}

//https://pt.stackoverflow.com/q/58055/101
