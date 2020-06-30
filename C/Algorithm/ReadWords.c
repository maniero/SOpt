#include <stdio.h>
#include <stdlib.h>

int main() {
    char **texto = NULL;
    int i = 0;
    char letra;
    do {
        texto = realloc(texto, (i + 1) * sizeof(char*));
        texto[i] = NULL;
        int j = 0;
        do {
            letra = getchar();
            texto[i] = realloc(texto[i], j + 1);
            texto[i][j] = letra;
            if (i == 2) printf("%c", letra);
            j++;
        } while (letra != ' ' && letra != '\n');
        i++;
    } while (letra != '\n');
    free(texto);
}

//https://pt.stackoverflow.com/q/460146/101
