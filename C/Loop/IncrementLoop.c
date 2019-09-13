#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int random() {
    float x;
    srand((unsigned)time(NULL));
    x = rand() % 100 + 1;
    x = x / 100;
    return x;
}

float prob() {
    float p;
    printf("Probabilidade: ");
    scanf("%f", &p);
    return p;
}

int label(float lattice[][4], float p) {
	for (int i = 0; i < 4 ; i++)
	    for (int j = 0; j < 4; j++) lattice[i][j] = random();
	for (int i = 0; i < 4; i++)
	    for (int j = 0; j < 4; j++) {
	        if (lattice[i][j] <= p) lattice[i][j] = 1;
	        else lattice[i][j] = 0;
	    }
	return 0;
}

int main() {
    float lattice[4][4];
    float p = prob();
    label(lattice, p);
}

//https://pt.stackoverflow.com/q/76582/101
