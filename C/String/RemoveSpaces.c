#include <stdio.h>
#include <string.h>

int main() {
	char string[101];
	int posicao = 0;
	printf("Forneca uma string com espacos em branco: ");
	fgets(string, sizeof(string), stdin);//mudei aqui para modernizar. ideone ñ aceita gets
	int len = strlen(string); //só pra dar melhor performance
	printf("%s\n", string);
	for (int i = 0; i < len; i++) {
		if (string[i] == ' ') continue;
		string[posicao] = string[i];
		posicao++;
	}
	string[posicao] = '\0'; // coloca o null no fim pra finalizar a string
	printf("String sem espaços em branco: %s\n", string);
}

//https://pt.stackoverflow.com/q/127177/101
