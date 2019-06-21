#include <stdio.h>

typedef struct {
    char s[10];
    int a, b;
    double x;
} Tipo;

int main(){
    Tipo v1[10];
    for (int i = 0; i < 10; i++) v1[i].b = 1;
    for (int i = 0; i < 10; i++) printf("%d\n", v1[i].b);
}

//https://pt.stackoverflow.com/q/392380/101
