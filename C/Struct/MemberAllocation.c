#include <stdio.h>
#include <stdlib.h>

struct MinhaStructExemplo {
    int *atributo_quantidade;
};

int main(void) {
    int *valor;
    struct MinhaStructExemplo structExemplo;
    valor = malloc(sizeof(int));
    *valor = 10;
    structExemplo.atributo_quantidade = valor;
    printf("%d\n", *structExemplo.atributo_quantidade);
    structExemplo.atributo_quantidade = malloc(sizeof(int));
    *structExemplo.atributo_quantidade = 30;
    printf("%d\n", *structExemplo.atributo_quantidade);
    structExemplo.atributo_quantidade = malloc(sizeof(int) * 3);
    structExemplo.atributo_quantidade[0] = 1;
    structExemplo.atributo_quantidade[1] = 2;
    structExemplo.atributo_quantidade[2] = 3;
    printf("%d\n", structExemplo.atributo_quantidade[0]);
    printf("%d\n", structExemplo.atributo_quantidade[1]);
    printf("%d\n", structExemplo.atributo_quantidade[2]);
}

//https://pt.stackoverflow.com/q/100653/101
