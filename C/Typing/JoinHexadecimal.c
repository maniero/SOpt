#include <stdio.h>

int main(void) {
	int v[4] = {0x0A, 0xBB, 0x4B, 0x18};
    for (int i = 0; i < 4; i++) printf("%02X", v[i]);
}

//https://pt.stackoverflow.com/q/51965/101
