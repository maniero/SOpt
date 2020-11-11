#include <stdio.h>
#include <limits.h>
#define NUM 5

int main(){
	float notas[NUM];
	float maior = 0, menor = INT_MAX, media;
	for (int i = 0; i < NUM; i++) {
		scanf("%f", &notas[i]);
		maior = notas[i] > maior ? notas[i] : maior;
		menor = notas[i] < menor ? notas[i] : menor;
		media += notas[i];
	}
	media /= NUM;
	printf("%.1f %.1f %.1f\n\n", maior, menor, media);
	for (int i = 0; i < NUM; i++) printf("%.1f ", notas[i]);
}

//https://pt.stackoverflow.com/q/157124/101
