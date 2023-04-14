#include <stdio.h>
#include <setjmp.h>

static jmp_buf buf;

void second() {
    printf("second\n");         // prints
    longjmp(buf,1);             // jumps back to where setjmp was called - making setjmp now return 1
}

void first() {
    second();
    printf("first\n");          // does not print
}

int main() {
    if (!setjmp(buf))
        first();                // when executed, setjmp returned 0
    else                        // when longjmp jumps back, setjmp returns 1
        printf("main\n");       // prints
    return 0;
}

//https://pt.stackoverflow.com/q/581386/101
