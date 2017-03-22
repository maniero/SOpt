#include <stdio.h>

typedef enum {um = 1, dois = 2, tres = 3} Numeros;

int main(void) {
	Numeros numero = um;
	numero++;
	printf("%d", numero);
}


//http://pt.stackoverflow.com/q/191724/101
