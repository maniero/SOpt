#include <stdio.h>

typedef struct {
    enum { is_int, is_float, is_char, is_pointer } type;
    union {
        int i;
        float f;
        char c;
        void *p;
    } value;
} Tipo;

int main(void) {
	int x = 10;
	float y = 5.5f;
	char c = 'h';
	char a[] = "teste";
	Tipo var1 = { .type = is_int, .value.i = x };
	Tipo var2 = { .type = is_float, .value.f = y };
	Tipo var3 = { .type = is_char, .value.c = c };
	Tipo var4 = { .type = is_pointer, .value.p = a };
	printf("%d\n", var1.value.i);
	printf("%f\n", var2.value.f);
	printf("%c\n", var3.value.c);
	printf("%s\n", (char *)var4.value.p);
	printf("%d\n", var2.type);
	printf("%zd\n", sizeof(var2));
	printf("%d\n", var3.type);
	printf("%zd\n", sizeof(var3));
}

//http://pt.stackoverflow.com/q/180783/101
