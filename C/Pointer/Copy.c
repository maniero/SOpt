#include <stdio.h>

int main() {
    int p1 = 10;
    int *p2 = &p1;
    int *ptr = p2;
    printf("%i\n%i\n%i\n%p", *p2, *ptr, p1, (void *)p2);
}

//https://pt.stackoverflow.com/q/542576/101
