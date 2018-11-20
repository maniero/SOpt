#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void trocar(char **a, char **b) {
    char *novo = *a;
    *a = *b;
    *b = novo;
}

int main() {
    char *a = malloc(3);
    strcpy(a, "oi");
    char *b = malloc(6);
    strcpy(b, "tchau");
    trocar(&a, &b);
    printf("a: %s, b: %s\n", a, b);
}

//https://pt.stackoverflow.com/q/344274/101
