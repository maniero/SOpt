#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
    char* letra = "A";
    char *buffer = malloc(strlen(letra) + 6); //6 é o tamanho de "echo ", incluindo o terminador, dá para optimizar
    if (sprintf(buffer, "echo %s", letra) > 0) printf(buffer);
    else printf("algo deu errado");
}

//https://pt.stackoverflow.com/q/311764/101
