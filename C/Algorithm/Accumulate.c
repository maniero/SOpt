#include <stdio.h>

int main() {
    int N;
    int somapar = 0;
    int somaimpar = 0;
    do {
	    printf("\n Digite um número qualquer: ");
	    scanf("%d", &N);
	    if (N % 2 == 0) {
	        printf("\n Número escolhido é par!");
	        somapar += N;
	    } else {
	        printf("\n Número escolhido é ímpar");
	        somaimpar += N;
	    }
    } while (N >= 0);
    printf("\nTotal de ímpares é %d e total de pares é %d\n", somaimpar, somapar);
}

//https://pt.stackoverflow.com/q/158640/101
