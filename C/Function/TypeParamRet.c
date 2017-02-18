#include <stdio.h>
#include <stdlib.h>
#include <math.h>

float calculafx(float x2, float *f3, float *f4, int m) {
	float fx1 = 0;
	for (int j = 1; j <= m; j++) {
    	fx1 += f3[j] * pow(x2, f4[j]);
	}
	return fx1;
}

int main() {
	int n;
	float epsilon, fa, fb, x1, fxx1, a, b;
	printf("Digite o número de termos da função: \n");
	scanf("%d", &n);
	system("clear");
	float f1[n], f2[n];
	printf("Digite o epsilon: \n");
	scanf("%f", &epsilon);
	printf("Digite o primeiro valor do intervalo: \n");
	scanf("%f", &a);
	printf("Digite o segundo valor do intervalo: \n");
	scanf("%f", &b);
	system("clear");
	for(int i = 1; i <= n; i++) {
		printf("Digite o termo %d da função:\n", i);
		scanf("%f", &f1[i]);
		printf("Digite o grau do termo: \n");
		printf("Digite 0 se o termo for uma constante:\n");
		scanf("%f", &f2[i]);
		system("clear");
	}
	
	do {
		x1 = (a + b) / 2;
		fxx1 = calculafx(x1, f1, f2, n);
		if (fxx1 * calculafx(a, f1, f2, n) < 0) {
		    b = x1;
		} else {
		    a = x1;
		}
	} while (abs(a - b) > epsilon);
	fa = calculafx(a, f1, f2, n);
	fb = calculafx(b, f1, f2, n);
	printf("f(a) é igual a %f e f(b) é igual a %f \n", fa,fb);
}

//http://pt.stackoverflow.com/q/185068/101
