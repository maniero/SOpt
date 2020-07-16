#include <stdio.h>
#include <stdlib.h>

int soma(int a, int b) {
    return a + b;
}

int main(int argc, char *argv[]) {
    printf("Soma: %d", soma((int)strtol(argv[1], NULL, 10) + (int)strtol(argv[2], NULL, 10)));
}

//https://pt.stackoverflow.com/q/290620/101
