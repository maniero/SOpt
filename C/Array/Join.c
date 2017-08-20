#include <stdio.h>

void criaVetor(int v[], int v1[], int v2[]) {
    for (int i = 0; i < 5; i++) {
        v[i] = v1[i];
    }
    for (int i = 0; i < 5; i++) {
        v[i + 5] = v2[i];
    }
}

void mostraVetor(int v[]) {
	for (int i = 0; i < 10; i++) {
	    printf("O numero posicao [%d] e %d\n", i, v[i]);
	}
}

int main(void) {
	int v[10];
	int v1[] = {1, 2, 3, 4, 5};
	int v2[] = {6, 7, 8, 9, 10};
	criaVetor(v, v1, v2);
	mostraVetor(v);
}

//https://pt.stackoverflow.com/q/230630/101
