#include<stdio.h>

int main() {
	float g, j, gus = 1.40, jul = 1.10;
	int cont = 0;
	scanf("%f %f", &g, &j);
	if (g <= j) {
		printf("Nunca alcancará");
		return 0;
	}
	g /= 100;
	j /= 100;
	while (jul <= gus) {
	    jul += j;
	    printf("%lf\n", jul);
	    gus += g;
	    printf("%lf\n", gus);
	    cont++;
	}
	printf("%d", cont);
}

//https://pt.stackoverflow.com/q/329729/101
