#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void copiaStr(char *a, char **b) {
    *b = malloc(strlen(a));
    for (int i = 0; i < strlen(a); i++) *(b[i]) = a[i];
}

int main() {
    char *a = "alou";
    char *b;
    printf("%s\n", a);
    copiaStr(a, &b);
    printf("%s\n", b);
}

//https://pt.stackoverflow.com/q/361433/101
