#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define QTD_NOMES 2
#define TAM_NOME 30

int soChars(char *nome, int tamanho) {
    for (int i = 0; i < tamanho; i++) {
        if (isdigit(nome[i]) != 0) {
            printf("\nNome invalido!\nDigite apenas letras!\n");
            return 0;
        }
    }
    return 1;
}

void leValidaNome(char *nome) {
    while (1) {
        printf("Informe seu nome:");
        scanf(" %[^\n]s", nome);
        int tamanho = strlen(nome);
        if (tamanho == 0) printf("\nNome invalido!\nDigite algo!\n");
        else if (soChars(nome, tamanho)) return;
    }
}

int main() {
    char nomes[QTD_NOMES][TAM_NOME];
    for (int i = 0; i < QTD_NOMES; i++) leValidaNome(nomes[i]);
    for (int j = 0; j < strlen(nomes[0]); j++) nomes[0][j] = toupper(nomes[0][j]);
    for (int i = 1; i < QTD_NOMES; i++) {
        for (int j = 0; j < strlen(nomes[i]); j++) nomes[i][j] = tolower(nomes[i][j]);
    }
    printf("\n%s\n%s", nomes[0], nomes[1]);
}

//https://pt.stackoverflow.com/q/326024/101
