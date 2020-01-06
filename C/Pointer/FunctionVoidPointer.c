#include <stdio.h>

int sum(int a, int b) {
    return a + b;
}

int main() {
    void* foo = &sum;
    int (*f)(int, long long) = foo;
    printf("Esta soma e ilegal? Soma = %d\n", f(10, 1000000000000L));
}

//https://pt.stackoverflow.com/q/429177/101
