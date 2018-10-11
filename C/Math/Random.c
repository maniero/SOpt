#include <time.h>
#include <stdlib.h>
#include <stdio.h>

int main(void) {
    srand(time(NULL));
    int r = rand() % 13; //é número de cartas de cada naipe
    printf("Número sorteado %d", r);
	return 0;
}

//https://pt.stackoverflow.com/q/41829/101
