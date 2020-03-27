#include <stdio.h>

int main () {
	int matriz[3][3], somalinha[3] = { 0 };
	for (int i = 0; i < 3; i++) {
	    for (int h = 0; h < 3; h++) {
	        printf("Digite os valores de uma matriz 3x3:\n");
	        scanf("%d", &matriz[i][h]);
	        somalinha[i] += matriz[i][h];
	    }
	    printf("O resultado da soma da linha %d eh %d\n", i, somalinha[i]);
	}
}

//https://pt.stackoverflow.com/q/170981/101
