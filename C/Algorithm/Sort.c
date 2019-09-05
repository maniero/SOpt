#include <stdio.h>

int main(void) {
	int vet[10];
	int aux;
    for (int i = 0; i < 10; i++) scanf("%i", &vet[i]);
    for (int i = 0; i < 10; i++) {
    	for (int j = i + 1; j < 10; j++) { 
            if(vet[i] > vet[j]) {
                aux = vet[i];
                vet[i] = vet[j];
                vet[j] = aux;
            }
    	}
        printf("%i", vet[i]);
    }
}

//https://pt.stackoverflow.com/q/58462/101
