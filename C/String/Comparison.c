#include <stdio.h>
#include <stdlib.h>
#include <string.h>
char *substring(char *str, char *buf, int start, int end) {
    for (int i = start; i < end; i++) buf[i] = str[i];
    return buf;
}

int main() {
	char *texto = malloc(6);
    if (strncmp(substring("Hello World", texto, 0, 5), "Hello", 5) == 0) printf("yep");
    free(texto);
}

//https://pt.stackoverflow.com/q/128614/101
