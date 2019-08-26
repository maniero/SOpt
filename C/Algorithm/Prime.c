#include<stdio.h>

int main() {
	int n;
	printf("Digite um numero para saber se eh primo: \n");
	scanf("%d", &n);
	int divisivel = 0;
    for (int i = n; i > 1; i--) {
        if (n % i == 0) {
            divisivel++;
            if (divisivel == 2) {
            	printf("o numero %i não eh primo \n", n);
            	return 0;
            }
        }
    }
    printf("o numero %i eh primo \n", n);
}

//https://pt.stackoverflow.com/q/405491/101
