#include <stdio.h>
#include <stdlib.h>

void retorna_algo(int size, int* destino) {
    if (size == 1) {
        *destino = 1;
    } else if (size == 3) {
        destino = (int[]){1, 2, 3};
    }
}

int main(void) {
    int *i = malloc(sizeof(int));
    retorna_algo(1, i);
    printf("%d\n", *i);
    i = realloc(i, sizeof(int)*3);
    retorna_algo(3, i);
    printf("%d | %d | %d\n", i[0], i[1], i[2]);
    i = (int[]){1, 2, 3};
    printf("%d | %d | %d\n", i[0], i[1], i[2]);
}

//https://pt.stackoverflow.com/q/275720/101
