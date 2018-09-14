#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int exemplo1() { return 1; }

int exemplo2(int i) { return i * 2; }

int exemplo3() {
    srand(time(0));
    return rand();
}

int exemplo4(int i) { return i > 0 ? 1 : 0; }

int main(void) {
	printf("%i\n", exemplo1());
	printf("%i\n", exemplo2(2));
	printf("%i\n", exemplo3());
	printf("%i\n", exemplo4(2));
}

//https://pt.stackoverflow.com/q/38935/101
