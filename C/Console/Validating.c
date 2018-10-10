#include <stdio.h>

int main(void) {
	int x;
    while (scanf("%d", &x) != 0 && x <= 0) printf("0 ou < 0 nao forma um triangulo por favor digite novamente a medida X\n");
    printf("%d", x);
}

//https://pt.stackoverflow.com/q/335230/101
