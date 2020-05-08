#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
    int numero;
} Estrutura;

int main(int argc, char *argv[]){
    Estrutura *i = malloc(sizeof(Estrutura));
    Estrutura *d = malloc(sizeof(Estrutura));
    i->numero = 5;
    memcpy(d, i, sizeof(Estrutura));
    i->numero = 6;
    printf("%d", d->numero);
    printf("%d", i->numero);
}

//https://pt.stackoverflow.com/q/450547/101
