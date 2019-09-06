#include <stdio.h>

int main() {
	int num1, num2;
	printf("Digite o valor do primeiro numero\n");
	scanf("%d", &num1);
	printf("Digite o valor do segundo numero\n");
	scanf("%d", &num2);
	if (num1 > num2) {
		int temp = num1;
	    num1 = num2;
	    num2 = temp;
	}
    printf("O valor do primeiro numero é:\n", num1);
    printf("O valor do segundo numero é:\n", num2);
}

//https://pt.stackoverflow.com/q/407972/101
