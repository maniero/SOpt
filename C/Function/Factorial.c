#include <stdio.h>

int fatorial(int num) {
    if (num >= 0) {
        int fat = 1;
        while (num > 0) {
            fat *= num;
            num--;
        }
        return fat;
    } else {
        return -1;
    }
}

int main(void) {
	printf("%d\n", fatorial(0));
	printf("%d\n", fatorial(1));
	printf("%d\n", fatorial(5));
	printf("%d\n", fatorial(-5));
}

//http://pt.stackoverflow.com/q/185600/101
