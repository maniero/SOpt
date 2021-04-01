#include <stdio.h>

void convmaiuscula(char texto[11]) {
    for (int i = 0; texto[i] != '\0'; i++) texto[i] -= 32;
    printf("A palavra em maiusculas %s", texto);
}

int main() {
    char palavra[11];
    printf("Digite uma palavra: ");
    scanf("%s10", palavra);
    convmaiuscula(palavra);
}

//https://pt.stackoverflow.com/q/502947/101
