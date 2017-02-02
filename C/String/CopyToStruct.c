#include <stdio.h>
#include <string.h>

typedef struct {
    char nome[30];
    int idade;
} p;

int main(void) {
    p x,y; 

    strcpy(x.nome, "ana");
    x.idade = 20;
    strcpy(y.nome, "caio");
    y.idade = 22;

    printf("%s : %d", x.nome, x.idade);
    printf("%s : %d", y.nome, y.idade);
}

//http://pt.stackoverflow.com/q/181556/101
