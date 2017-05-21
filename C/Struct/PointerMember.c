#include <stdio.h>
#include <stdlib.h>

typedef struct {
    char *teste_str;
    int teste_int;
} TesteA;

typedef struct {
    TesteA **t;
} TesteB;

int main(void) {
    TesteB teste;
    teste.t = malloc(3 * sizeof(TesteA*));
    teste.t[0]->teste_int = 25;
    printf("%d\n", teste.t[0]->teste_int);
    return 0;
}

//https://pt.stackoverflow.com/q/206288/101
