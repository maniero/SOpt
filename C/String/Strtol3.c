#include <stdio.h>
#include <stdlib.h>

void soma(int a, int b) {
    printf("%d\n", a + b);
}

int main(int argc, char *argv[]) {
    printf("Soma: ");
    soma((int)strtol(argv[1], NULL, 10) + (int)strtol(argv[2], NULL, 10))
}

//https://pt.stackoverflow.com/q/290620/101
