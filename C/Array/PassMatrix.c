#include <stdio.h>
#include <stdlib.h>

void matriz_ponteiro(int mtr[3][4]) {
     for (int lin = 0; lin < 3; lin++) {
	    for (int col = 0; col < 4; col++) printf("\t%d", mtr[lin][col]);
        printf("\n");
    }
}

int main () {
	int mtr[3][4];
	for (int lin = 0, cont = 0; lin < 3; lin++) for (int col = 0; col < 4; col++) mtr[lin][col] = cont++;
	matriz_ponteiro(mtr);
}

//https://pt.stackoverflow.com/q/165524/101
