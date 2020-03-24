#include <stdio.h>

int main() {
	int num = 1, qpar = 0, qimp = 0;
	while (num != 0) {
		printf("Introduza\n");
		scanf("%d", &num);
		if (num % 2 == 0) {
			qpar++;
		} else {
			qimp++;
		}
	}
	printf("Pares -> %d\n", qpar);
	printf("Impares -> %d\n", qimp);
}

//https://pt.stackoverflow.com/q/167111/101
