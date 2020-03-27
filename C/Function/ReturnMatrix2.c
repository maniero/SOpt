#include <stdio.h>
#include <stdlib.h>
#include <math.h>
 
int *integerPower(int y) {
	int *ret = malloc(4 * sizeof(int));
    ret[0] = pow(y, 2);
    ret[1] = pow(y, 3);
    ret[2] = pow(y, 4);
    ret[3] = ret[0] + ret[1] + ret[2];
    return ret;
}
int main(void) {
	int *valores = integerPower(5);
	printf("%d\n", valores[0]);
	printf("%d\n", valores[1]);
	printf("%d\n", valores[2]);
	printf("%d\n", valores[3]);
	free(valores);
}

//https://pt.stackoverflow.com/q/171149/101
