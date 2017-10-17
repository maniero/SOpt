#include <stdio.h>
#include <string.h>
#define NUM_DEF 7

struct dicionario {
    char palavra[20];
    char definicao[50];
};

int procString (const struct dicionario lingua[], const char 
procurar[], int numPalavra) {
    for (int i = 0; i < numPalavra; i++) {
        if (strcmp(lingua[i].palavra, procurar) == 0) {
        	return i;
        }
    }
    return -1;
}

int main(void) {
    const struct dicionario portu[NUM_DEF] = {
    {"pao","comida de farinha"},
    {"feijao","comida brasileira"},
    {"tropeiro","tipo de feijao"},
    {"queijo","comida de minas"},
    {"macarrao","comida de vo"},
    {"mortadela","comida de carne"},
    {"pizza","comida da italia"}};
    printf("Digite uma palavra:\n");
    char palavra[20] = {'\0'};
    scanf("%s", palavra);
    int resultadoPesquisa = procString(portu, palavra, NUM_DEF);
    if (resultadoPesquisa != -1) {
        printf("%s\n", portu[resultadoPesquisa].definicao);
    } else {
        printf("Palavra n encontrada");
    }
}

//https://pt.stackoverflow.com/q/246722/101
