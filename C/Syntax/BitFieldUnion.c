#include <stdio.h>

typedef union {
    char valor;
    struct {
        unsigned char a : 1;
        unsigned char b : 1;
        unsigned char c : 1;
        unsigned char d : 1;
        unsigned char e : 1;
        unsigned char f : 1;
        unsigned char g : 1;
        unsigned char : 1;
    } bits;
} Tipo;

int main(void) {
	Tipo x = { .valor = 87 };
	printf("%d %d %d %d %d %d %d", x.bits.a, x.bits.b, x.bits.c, x.bits.d, x.bits.e, x.bits.f, x.bits.g);
}

//http://pt.stackoverflow.com/q/178733/101
