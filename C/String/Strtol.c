#include <stdio.h>
#include <stdlib.h>

static char *argv[] = { "app", "123", "456" }; //gambiarra pra simular a passagem de argumento pela linha de comando

int main(/*int argc, char *argv[] */) {
    printf("Soma: %ld", strtol(argv[1], NULL, 10) + strtol(argv[2], NULL, 10));
}

//https://pt.stackoverflow.com/q/290587/101
