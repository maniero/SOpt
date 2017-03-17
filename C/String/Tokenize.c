#include <stdio.h>
#include <string.h>

int main(void) {
    char frutas[] = "banana,laranja,morango";
    int tamanho = strlen(frutas); //isto funciona só para delimitador de 1 caractere
    char *token = strtok(frutas, ",");
    for (int i = 0; i < tamanho; i++) {
        printf(token[i] == 0 ? "\\0" : "%c", token[i]);
    }
    while(token != NULL) {
        printf("\n%s", token);
        token = strtok(NULL, ",");
    }
}

//http://pt.stackoverflow.com/q/190755/101
