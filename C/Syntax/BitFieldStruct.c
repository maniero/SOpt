#include <stdio.h>

typedef struct {
    unsigned char a : 1;
    unsigned char b : 7;
} Tipo;

int main(void) {
	Tipo x = { .a = 1, .b = 64 };
	printf("%d e %d\n", x.a, x.b);
	printf("%d\n", sizeof(Tipo));
}

//http://pt.stackoverflow.com/q/178733/101
