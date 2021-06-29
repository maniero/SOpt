#include <stdio.h>
#include <stddef.h>

typedef struct {
    long long ll;
    int i;
    short s;
    char ch1;
    char ch2;
} Tipo; 
	
int main(void) {
    Tipo var = { .ll = 1000000000000, .i = 1000, .s = 10, .ch1 = 'a', .ch2 = 's' };
    printf("%lld\n", var.ll);
    printf("%i\n", var.i);
    printf("%d\n", var.s);
    printf("%c\n", var.ch1);
    printf("%c\n", var.ch2);
    printf("%lld\n", *((long long*)(((char*)&var) + offsetof(Tipo, ll))));
    printf("%i\n", *((int*)(((char*)&var) + offsetof(Tipo, i))));
    printf("%d\n", *((short*)(((char*)&var) + offsetof(Tipo, s))));
    printf("%c\n", *((char*)(((char*)&var) + offsetof(Tipo, ch1))));
    printf("%c\n", *((char*)(((char*)&var) + offsetof(Tipo, ch2))));
}

//http://pt.stackoverflow.com/q/183287/101
