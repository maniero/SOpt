#include <stdio.h>

int main(void) {
	double notas[10];
	for (int i = 0; i < 10; i++) {
	    printf("Digite %d: ", i);
	    scanf("%lf", &notas[i]);
	}
	int j = 0, count = 0;
	double soma = 0;
	for (int i = 0; i < 10; i++) {
	    if (notas[i] > 5) {
	        soma = soma + notas[i];
	        count++;
	    }
	}
	double media = soma / count;
	int P[10];
	for (int i = 0; i < 10; i++) {
	    if (notas[i] >= media) {
	        P[j] = i;
	        j++;
	    }
	}
    printf("%.2lf\n", media);
	for (int i = 0; i < j; i++) {
	    printf("%d  ", P[i]);
	}
}

//https://pt.stackoverflow.com/q/148093/101
