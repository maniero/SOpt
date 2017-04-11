#include <stdio.h>
#include <stdlib.h>    

void dec2bin(char operadores[], int numero, int qtdadeBits) {
	for (int i = qtdadeBits - 1; i >= 0; i--) {
		int deslocamento = numero >> i;
	    operadores[qtdadeBits - 1 - i] = deslocamento & 1 ? '1' : '0';
	}
}

int main() {
    char operadores[200] = { 0 };
    dec2bin(operadores, 10, 5);
    printf("%s", operadores);
}

//http://pt.stackoverflow.com/q/197558/101
