#include <stdio.h>
typedef struct {
   int a;
} Exemplo;

int main(void) {
    Exemplo p = { 10 };
    printf("valor = %d\n", p.a);
    Exemplo p2 = { .a = 10 };
    printf("valor = %d\n", p2.a);
    Exemplo p3;
    p3.a = 10;
    printf("valor = %d\n", p3.a);
}

//https://pt.stackoverflow.com/q/105224/101
