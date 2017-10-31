#include <stdio.h>
#include <math.h>

int reverse(int num) {
    int inv = 0;
    int dig = 0;
    for (int i = 2; i >= 0; i--) {
        dig = num / (int)pow(10.0, (double)i); //infelizmente C não tem uma função de potência para inteiro
        num -= dig * (int)pow(10.0, (double)i);
        inv += dig * (int)pow(10.0, (double)(2 - i));
    }
    return inv;
}

int main(void) {
	printf("%d", reverse(123));
}

//https://pt.stackoverflow.com/q/37031/101
