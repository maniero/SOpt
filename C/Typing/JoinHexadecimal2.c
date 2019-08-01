#include <stdio.h>

int main(void) {
	int v[4] = {0x0A, 0xBB, 0x4B, 0x18};
    int resultado = 0;
    for (int i = 0; i < 4; i++) {
    	resultado *= 256;
    	resultado += v[i];
    }
    printf("%08X", resultado);
}

//https://pt.stackoverflow.com/q/51965/101
