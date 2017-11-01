#include <stdio.h>
#include <stdlib.h>

int* uniao(int *v1, int n1, int *v2, int n2){
	int *v3 = malloc((n1 + n2) * sizeof(int *));
	for (int i = 0; i < n1; i++) v3[i] = v1[i];
	for (int i = n1, j = 0; j < n2; i++, j++) v3[i] = v2[j];
	return v3;
}

int main(void) {
	int v1[] = { 1, 2, 3 };
	int v2[] = { 4, 5, 6 };
	int *pAux = uniao(v1, 3, v2, 3);
	for (int i = 0; i < 6; i++) {
	    printf("%d\n", pAux[i]);
	}
}

//https://pt.stackoverflow.com/q/251687/101
