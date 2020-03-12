#include <stdio.h>
#include <string.h>

int main(void) {
    char texto[50];
    printf("\nInforme seu nome completo: ");
    fgets(texto, 50, stdin);
    int cont = strlen(texto);
    printf("\nO tamanho da string: %i\n", cont);
    for (int i = 0; i < cont; i++) printf("%d ", texto[i]);
    texto[cont - 1] = '\0';
    cont = strlen(texto);
    printf("\nO tamanho da string: %i\n", cont);
}

//https://pt.stackoverflow.com/q/157168/101
