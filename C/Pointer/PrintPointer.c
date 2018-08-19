#include <stdio.h>

int main() {
    int x=2;
    int *p = &x;
    printf("O endereço de X e: %p\n", (void *)p);
    printf("O valor de X e: %d\n", *p);
}

//https://pt.stackoverflow.com/q/323460/101
