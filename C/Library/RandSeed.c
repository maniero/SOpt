#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int geraAleatorio(int min, int max) {
    return ((rand() % (max - min)) + min) + 1;
}

int main(void) {
	srand((unsigned)time(NULL));
	printf("%d\n", geraAleatorio(10, 20));
	printf("%d\n", geraAleatorio(10, 20));
	printf("%d\n", geraAleatorio(30, 40));
}

//http://pt.stackoverflow.com/q/186730/101
