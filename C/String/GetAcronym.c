#include<stdio.h>

int main() {
    char nome[99];
    printf("Digite o nome completo:\n");
    fgets(nome, 98, stdin);
    int qtdA = 0;
    for (int i = 0; nome[i] != 0; i++) {
        if (nome[i] == 'a' || nome[i] == 'A') qtdA++;
        if (nome[i] != ' ' && (i == 0 || nome[i - 1] == ' ')) printf("%c.", nome[i]);
    }
    printf("\nSeu nome tem %d letras 'A'" , qtdA);
}

//https://pt.stackoverflow.com/q/257521/101
