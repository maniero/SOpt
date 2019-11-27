#include <stdio.h>

typedef struct elem {
    void * d;
} Elem;

int main() {
    Elem *p = &(struct elem) { .d = NULL }; //malloc(sizeof(Elem));
    Elem e;
    double pi = 3.14;
    e.d = &pi;
    p->d = &pi;
    printf("%f\n", *((double *)p->d));
    printf("%f\n", *((double *)e.d));
}

//https://pt.stackoverflow.com/q/110588/101
