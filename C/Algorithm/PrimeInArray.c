#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(void) {
    int n[10];
    srand(time(NULL));
    for (int i = 0; i < 10; i++) {
        n[i] = rand() % 250;
        printf("%d numero: %d\n", i, n[i]);
    }
    printf("\n");
    for (int i = 0; i < 10; i++) {
    	int j = 2;
        for (; j < n[i]; j++) if (n[i] % j == 0) break;
        if (n[i] == j) printf("O numero %d e primo\n", n[i]);
    }
}

//https://pt.stackoverflow.com/q/44537/101
