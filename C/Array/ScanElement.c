#include <stdio.h>

int main() {
	int a[2];
	for (int y = 0; y < 2; y++) {
	    printf("Digite um número : ");
	    scanf("%d", &a[y]);
	}
	int i = *a;
	printf("Primeiro elemento do array = %d ", i);
}

//https://pt.stackoverflow.com/q/217719/101
