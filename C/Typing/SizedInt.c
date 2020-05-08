#include <stdio.h>
#include <stdint.h>

int getBit8(int *pInt32, int index) {
    return (*pInt32 >> (index * 8)) & (0xff >> sizeof(int));
}

int getBit8x(int32_t *pInt32, int index) {
    return (*pInt32 >> (index * 8)) & (0xff >> 32);
}

int main() {
	int a[] = { 0, 1, 2, 3 };
	getBit8(a, 2);
	getBit8x(a, 1);
	printf("%d %d %d %d", a[0], a[1], a[2], a[3]);
}

//http://pt.stackoverflow.com/q/190575/101
