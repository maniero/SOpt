#include <stdio.h>

int main(void) {
    printf("tamanho de um inteiro: %d\n", (int)sizeof(int));
    if((int)sizeof(int) > -1) printf("4 é maior que -1");
    else printf("-1 é maior que 4");
}

//https://pt.stackoverflow.com/q/47724/101
