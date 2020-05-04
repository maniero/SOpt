#include <stdio.h>

int main(void) {
	int i, j, n;
	printf("Digite o valor de n: ");
	scanf("%d", &n);
	printf("Digite o valor de i: ");
	scanf("%d", &i);
	printf("Digite o valor de j: ");
	scanf("%d", &j);
	printf("Os %d primeiros multiplos de %d e %d sao : ", n, i, j);
	for (int c = 0, k = 0; k < n; c++) {
		if (c % (i * j) == 0) {
			printf("%d \t", c);
			k++;
		}
	}
}

//https://pt.stackoverflow.com/q/449480/101
