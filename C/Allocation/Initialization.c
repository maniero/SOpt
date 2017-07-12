#include<stdio.h>
#include<stdlib.h>

char *alocar_palavra() {
    char *palavra = malloc(20);
    scanf(" %s", palavra);
    return palavra;
}

char *alocar_frase() {
    char letra;
    int k = 0;
    char *frase = NULL;
    do {
        letra = getchar();
        frase = realloc(frase, k + 1);
        frase[k++] = letra;
    } while (letra != '$' && letra != '\n');
    return frase;
}

int main() {
    char *frase = alocar_frase();
    char *palavra = alocar_palavra();
    printf("%s", frase);
    printf("%s", palavra);
}

//https://pt.stackoverflow.com/q/219715/101
