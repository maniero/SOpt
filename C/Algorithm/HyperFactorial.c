#include <stdio.h>
#include <math.h>

int hiperfatorial(int n) {
    double ret = 1.0;
    do ret *= pow(n, n); while (n-- > 1);
    return (int)ret;
}

int main(void) {
	int n;
	printf("\nDigite um numero: ");
	scanf("%d", &n);
	printf("\nO hiperfatorial desse numero eh: %d", hiperfatorial(n));
}

//https://pt.stackoverflow.com/q/255963/101
