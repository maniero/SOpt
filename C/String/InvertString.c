#include <stdio.h>

int main() {
    char nome[7];
    printf("Digite uma palavra:");
    scanf("%6s", nome);
    for (int i = 0; i < 3; i++) {
        char letra = nome[i];
        nome[i] = nome[5 - i];
        nome[5 - i] = letra;
    }
    printf("\n%s", nome);
}

//https://pt.stackoverflow.com/q/439162/101
