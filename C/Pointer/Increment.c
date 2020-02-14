#include <stdio.h>

int main() {
    int *p, x = 10;
    p = &x;
    (*p)++;
    printf("%d \n", *p);
}

//https://pt.stackoverflow.com/q/143084/101
