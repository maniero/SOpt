#include <stdio.h>

int main(void) {
    printf("tamanho de um inteiro: %d\n", sizeof(int));
    printf("-1 com cast: %u\n", -1);
    if (sizeof(int) > -1) printf("4 é maior que -1");
    else printf("-1 é maior que 4");
}

//https://pt.stackoverflow.com/q/47724/101
