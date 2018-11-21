#include <stdio.h>

int main(int argc, char const *argv[]) {
    char x[4] = { 0, 127, 0, 0 };
    printf("%u\n", *((unsigned int *)x));
}

//https://pt.stackoverflow.com/q/344857/101
