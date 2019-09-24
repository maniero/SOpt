#include <stdio.h>

int main() {	
	int i = 1, x = 1, a, resultado;
	printf(" Introduza a quantidade de tabuadas que quer! ");
	scanf("%d", &a);
	do	{
		printf("\nTabuada do %d\n", x);
		while (i <= 10)	{
			resultado = i*x;
			printf(" %dx%d=%d\n", i, a, resultado);
			i++;
		}
		i = 1;
		x++;
	} while (x <= a);
}

//https://pt.stackoverflow.com/q/81136/101
