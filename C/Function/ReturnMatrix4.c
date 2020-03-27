#include <stdio.h>
#include <math.h>
 
typedef struct integerPowerTuple {
    int base1;
    int base2;
    int base3;
    int total;
} IntegerPowerTuple;

IntegerPowerTuple integerPower(int y) {
	IntegerPowerTuple tupla = { pow(y, 2), pow(y, 3), pow(y, 4), tupla.base1 + tupla.base2 + tupla.base3 };
	return tupla;
}
int main(void) {
	IntegerPowerTuple tupla = integerPower(5);
	printf("%d\n", tupla.base1);
	printf("%d\n", tupla.base2);
	printf("%d\n", tupla.base3);
	printf("%d\n", tupla.total);
}

//https://pt.stackoverflow.com/q/171149/101
