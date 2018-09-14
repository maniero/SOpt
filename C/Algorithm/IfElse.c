#include <stdio.h>

int main(void) {
	int v1, v2;
	printf("Valor 1 :"); scanf("%d", &v1);
	printf("Valor 2 :"); scanf("%d", &v2);
	if (v1 == v2) printf("O valor é igual\n");
	else printf("O valor é diferente\n");
	if (v1 > v2) printf("O valor maior é %d\nO valor menor é %d", v1, v2);
	else printf("O valor maior é %d\nO valor menor é %d", v2, v1);
}

//https://pt.stackoverflow.com/q/329552/101
