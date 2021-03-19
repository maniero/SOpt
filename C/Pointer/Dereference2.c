#include <stdio.h>
#include <stdlib.h>
 
int main () {
    char *p = malloc(2);
    p[0] = 'O';
    p[1] = 'i';
    p++;
    printf("%c\n", *p);
    printf("%p\n", p);
}

//https://pt.stackoverflow.com/q/498149/101
