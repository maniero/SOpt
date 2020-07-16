#include <stdio.h>
#include <stdlib.h>

int soma(char *primeiro, char *segundo) {
    return (int)strtol(primeiro, NULL, 10) + (int)strtol(segundo, NULL, 10));
}

int main(int argc, char *argv[]) {
    printf("Soma: %d", soma(argv[1], argv[2]));
}

//https://pt.stackoverflow.com/q/290620/101
