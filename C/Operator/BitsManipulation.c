#include <stdio.h>

int main(void) {
	int x0 = 0, x1 = 0, x2 = 1;
	printf("Valor de x0 | x2: %d\n", x0 | x2);
	printf("Valor de x1 | x2: %d\n", x1 | x2);
	printf("Valor de x1 | x2 << 1: %d\n", x1 | x2 << 1);
	printf("Valor de (x0 | x2) | (x1 | x2) << 1: %d\n", (x0 | x2) | (x1 | x2) << 1);
}

//https://pt.stackoverflow.com/q/201392/101
