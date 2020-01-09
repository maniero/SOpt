#include <stdio.h>
#include <string.h>
int main() {
	char string[101];
	printf("Forneca uma string com espacos em branco: ");
	fgets(string, sizeof(string), stdin);
	int len = strlen(string);
	printf("%s\n", string);
	for (int i = 0, posicao = 0; i < len; i++, posicao++) {
	    if (string[posicao] == ' ') posicao++;
        string[i] = string[posicao];
	}
	printf("String sem espaços em branco: %s\n", string);
}

//https://pt.stackoverflow.com/q/127177/101
