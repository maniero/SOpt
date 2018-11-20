#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void trocar(char *a, char *b) {
    char *novo = malloc(10);
    strcpy(novo, a);
    strcpy(a, b);
    strcpy(b, novo);
}

int main() {
    char *a = malloc(10);
    strcpy(a, "oi");
    char *b = malloc(10);
    strcpy(b, "tchau");
    trocar(a, b);
    printf("a: %s, b: %s\n", a, b);
}

//https://pt.stackoverflow.com/q/344274/101
