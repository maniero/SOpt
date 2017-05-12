#include <stdio.h>

float media(int n, float* v) {
	float s = 0;
	for (int i = 0; i < n; i++) {
		s += v[i];
	}
	return s / n;
}

float variancia(int n, float* v, float m) {
	float s = 0;
	for (int i = 0; i < n; i++) {
		s += (v[i]-m)*(v[i]-m);
	}
	return s/n;
}

int main() {
	float v[10];
	for (int i = 0; i < 10; i++) {
		printf("Digite um numero:\n");
		scanf("%f", &v[i]);
	}
	float med = media(10, v);
	float var = variancia(10, v, med);
	printf("Media = %f Variancia = %f \n", med, var);
}

//https://pt.stackoverflow.com/q/204372/101
