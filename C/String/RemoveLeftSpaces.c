#include <stdio.h>

void removerEspacosEsquerda(char string[]) {
	int cont = 0;
    for (int i = 0; string[i] != '\0'; i++, cont++) {
        if (string[i] == ' ') cont--;
        else string[cont] = string[i];
    }
    string[cont] = '\0';
}

int main() {
    char string[] = " teste";
    removerEspacosEsquerda(string);
    printf("%s", string);
}

//https://pt.stackoverflow.com/q/344240/101
