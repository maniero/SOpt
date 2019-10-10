#include <stdio.h>

int main(void) {
	int num1, num2, resto;
	printf("\n digite um valor: ");
	scanf("%d",&num1);
	printf("\n digite outro valor: ");
	scanf("%d",&num2);
	resto = num1 % num2;
	printf("\n %d \n", resto);
}

//https://pt.stackoverflow.com/q/88260/101
