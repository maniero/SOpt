#include <stdio.h>

int main () {
    char frase[200], palavra[200];
    scanf(" %[^\n]s", frase);
    int j = 0;
    for (int i = 0; frase[i] != '\0'; i++) {
        palavra[j] = frase[i];
        if (palavra[j] == ' ') {
        	if (frase[i + 1] != ' ' && frase[i + 1] != '\0') j = 0;
        } else j++;
    }
    palavra[j] = '\0';
    printf("%s", palavra);
}

//https://pt.stackoverflow.com/q/271902/101
