#include <stdio.h>

int main() {
    printf("Digite três caracteres:\n");
    char chars[4];
    scanf("%3s", chars);
    printf("Primeiro caractere: %c\nSegundo caractere: %c\nTerceiro caractere: %c\n", chars[0], chars[1], chars[2]);
}

//https://pt.stackoverflow.com/q/452177/101
