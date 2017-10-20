#include <stdio.h>

int main() {
    int i = 5;
    int *p;
    p = &i;
    printf("%u\n", p);
    printf("%d\n", *p);
    printf("%d\n", (*p) + 2);
    printf("%d\n", (&p));
    printf("%d\n", (*(&p)));
    printf("%d\n", *(*(&p)));
    printf("%d\n", 3 * (*p));
    printf("%d\n", *(*(&p)) + 4);
}

//https://pt.stackoverflow.com/q/247773/101
