#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct {
    char *nome;
} Tipo1;

typedef struct {
    char nome[30];
} Tipo2;

int main(void) {
    Tipo1 x;
    Tipo2 y;
    printf("%d\n", sizeof(x));
    printf("%d\n", sizeof(y));
}

//http://pt.stackoverflow.com/q/181609/101
