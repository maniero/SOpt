#include <stdio.h>
#include <stdlib.h>
typedef struct {
   int a;
} Exemplo;

int main(void) {
    Exemplo *p = malloc(sizeof(Exemplo));
    p->a = 10;    
    printf("valor = %d", p->a);
}

//https://pt.stackoverflow.com/q/105224/101
