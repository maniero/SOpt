#include <stdio.h>
#include <stdlib.h>

typedef struct {
    int i;
} Tipo;

int main() {
Tipo x = { .i = 10 };
    printf("%d", x.i);
    int y = x.i;
    printf("%d", y);
    Tipo *z = malloc(sizeof(Tipo));
    z->i = 10;
    printf("%d", z->i);
    y = z->i;
    printf("%d", y);
}

//http://pt.stackoverflow.com/q/183066/101
