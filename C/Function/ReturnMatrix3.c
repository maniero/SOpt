#include <stdio.h>
#include <math.h>
 
void integerPower(int y, int *base1, int *base2, int *base3, int *total) {
    *base1 = pow(y, 2);
    *base2 = pow(y, 3);
    *base3 = pow(y, 4);
    *total = *base1 + *base2 + *base3;
}
int main(void) {
	int base1, base2, base3, total;
	integerPower(5, &base1, &base2, &base3, &total);
	printf("%d\n", base1);
	printf("%d\n", base2);
	printf("%d\n", base3);
	printf("%d\n", total);
}

//https://pt.stackoverflow.com/q/171149/101
