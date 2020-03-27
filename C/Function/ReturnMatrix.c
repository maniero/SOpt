#include <stdio.h>
#include <math.h>

void integerPower(int y, int ret[4]) {
    ret[0] = pow(y, 2);
    ret[1] = pow(y, 3);
    ret[2] = pow(y, 4);
    ret[3] = ret[0] + ret[1] + ret[2];
}
int main(void) {
	int valores[4];
	integerPower(5, valores);
	printf("%d\n", valores[0]);
	printf("%d\n", valores[1]);
	printf("%d\n", valores[2]);
	printf("%d\n", valores[3]);
}

//https://pt.stackoverflow.com/q/171149/101
