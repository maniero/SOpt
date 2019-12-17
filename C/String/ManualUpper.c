#include <stdio.h>
#include <ctype.h>

void strupr(char *str) {
    while (*str) {
        *str = toupper(*str);
        str++;
    }
}

int main(void) {
    char texto[] = "teste";
    strupr(texto);
    printf("%s", texto);
}

//https://pt.stackoverflow.com/q/121280/101
