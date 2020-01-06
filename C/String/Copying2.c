#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
    char *str = "   teste";
    while (*str++ == ' ');
    str--;
    printf("%s", str);
}

//https://pt.stackoverflow.com/q/126134/101
