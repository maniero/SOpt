#include <stdio.h>

int main (void){
	float c, r;
	printf("Digite o salário\n");
	scanf("%f", &c);
	printf("Digite o reajuste percentual:\n");
	scanf("%f", &r);
	r *= 0.01;
	c = c * r + c;
	printf("Salário reajustado: %.2f\n", c);
}

//http://pt.stackoverflow.com/q/194610/101
