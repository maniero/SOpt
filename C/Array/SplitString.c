#include <stdlib.h>
#include <stdio.h>

int main() {
	char str[] = "Ola. Tudo bem?\n Sim e contigo?\n Comigo esta tudo bem! Que tens feito?\n Trabalho no projeto!\n";
	char **matriz = malloc(sizeof(char *) * 255);
	int linha = 0;
	matriz[linha] = malloc(255);
    for (int caractere = 0, coluna = 0; str[caractere] != '\0'; caractere++, coluna++) {
        if (str[caractere] == '\n' || str[caractere] == '\0') {
            matriz[linha][coluna] = '\0';
            matriz[linha] = realloc(matriz[linha], coluna + 1);
            matriz[++linha] = malloc(255);
            coluna = -1;
        } else {
            matriz[linha][coluna] = str[caractere];
        }
    }
    matriz = realloc(matriz, sizeof(char *) * linha);
    for (int i = 0; i < linha; i++) {
        printf("%s\n", matriz[i]);
    }
}

//https://pt.stackoverflow.com/q/254177/101
