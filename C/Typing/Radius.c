#include <stdio.h>
#include <math.h>
#ifndef M_PI
#    define M_PI 3.14159265358979323846
#endif
float param(int x) {
    return (4 * pow(x, 3)) / 3 * M_PI;
}
int main() {
	float x;
	printf("Digite o raio de uma esfera: ");
	scanf(" %f", &x);
	printf("\nO volume de uma esfera eh %f \n", param(x));
}

//https://pt.stackoverflow.com/q/493872/101
