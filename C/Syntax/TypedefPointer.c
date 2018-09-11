#include <stdio.h>
#include <stdlib.h>

typedef struct ponto {
   int a, b;
} Estrutura;

typedef Estrutura* Ponteiro;

int main() { 
    Ponteiro p = malloc(sizeof(Estrutura));
    printf("%p", (void *)p);
}

//https://pt.stackoverflow.com/q/328613/101
