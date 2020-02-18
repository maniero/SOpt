#include <stdio.h>
#include <stdlib.h>

float valor(float *k, int t){
	float soma = 0;
	for (int i = 0; i < t; i++) soma += k[i];
	return soma;
}

int main() {
	int quant;
	printf("Digite a quantidade: ");
	scanf("%d", &quant);
	float *vTotal = malloc(quant * sizeof(float));
	for (int i = 0; i < quant; i++){
	    printf("Digite o valor %d: ", i + 1);
	    scanf("%f", &vTotal[i]);
	}
    float teste = valor(vTotal, quant);
    printf("\n %.2f", teste);
    free(vTotal);
}

//https://pt.stackoverflow.com/q/148160/101
