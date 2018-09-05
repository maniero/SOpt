#include <stdio.h>
#include <stdlib.h>
#include <math.h>

void parImpar (int num) {
	int digitos = floor(log10(abs(num))) + 1;
	for (int i = digitos - 1; i >= 0; i--) {
	    int div = num / (int)pow(10, i);
	    num = num % (int)pow(10, i);
        printf(div % 2 == 0 ? "\n%d eh Par" : "\n%d eh Impar", div);
	}
}

int main() {
    int num;
    printf("Digite um numero inteiro: ");
    scanf("%d", &num);
    parImpar(num);        
}

//https://pt.stackoverflow.com/q/326351/101
