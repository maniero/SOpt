#include <stdio.h>
#include <stdlib.h>

struct Complexo {
    int real;
    int imaginario;
};

struct Complexo insereComplexo(int r, int i){
    struct Complexo novo;
    novo.real = r;
    novo.imaginario = i;
    return novo;
}

void somaComplexo(struct Complexo *a, struct Complexo b){
    a->real += b.real;
    a->imaginario += b.imaginario;
}

int main(int argc, char *argv[]){
    struct Complexo a, b;
    a = insereComplexo(4,7);
    b = insereComplexo(8,10);
    somaComplexo(&a, b);
    printf("%d\n", a.real);
    printf("%d\n", a.imaginario);
    system("pause");
}

//https://pt.stackoverflow.com/q/303412/101
