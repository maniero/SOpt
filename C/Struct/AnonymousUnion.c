#include<stdio.h>

typedef struct {
    union {
        char c;
        int i;
    };
} Tipo;
  
int main() {
	union {
        char c;
        int i;
    } x;
    x.i = 65;
    Tipo y;
    y.i = 65;
    printf("%c, %c", x.c, y.c);
}

//https://pt.stackoverflow.com/q/355640/101
