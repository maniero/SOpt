#include <stdio.h>

int leDados(FILE* arquivo, int numPalavras, char palavras[numPalavras][31]) {
    for (int i = 0; i < numPalavras; i++) {
	    if (fscanf(arquivo, "%30s", palavras[i]) == EOF) return i;
        //removeCharETornaMinuscula(palavra, '.', ',', ' ', ';', '"');
	}
	return 0;
}

int main(void) {
	char palavras[10][31];
	int numPalavras = leDados(stdin, 10, palavras);
	for (int i = 0; i < numPalavras; i++) printf("%s\n", palavras[i]);
}

//https://pt.stackoverflow.com/q/344029/101
