#include <stdio.h>
#include <stdlib.h>

int main(void) {
    int x[8];
    printf("Gerando 10 valores aleatorios:\n");
    for (int i = 0; i < 8; i++) {
        scanf("%d", &x[i]);
        if (x[i] == 3) {
        	int sorteado = -1;
        	while ((sorteado = rand() % 8) != i); //repete até achar um valor aceitável
            x[i] = sorteado;
        } else {
        	x[i] = rand() % 8;
        }
        printf("[%d] = %d\n", i, x[i]);
    }
}

//https://pt.stackoverflow.com/q/165778/101
