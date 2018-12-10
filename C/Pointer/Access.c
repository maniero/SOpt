#include <stdio.h>

int main(void) {
    int a = 9;
    int b = 3;
    int *p = &b;
    int c = a / (*p);
    printf("%d \n", c);
}

//https://pt.stackoverflow.com/q/43250/101
