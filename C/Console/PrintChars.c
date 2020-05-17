#include <stdio.h>

int main() {
	char c;
    printf("Digite um caractere:\n");
    char c1 = getchar();
    while ((c = getchar()) != '\n' && c != EOF) { }
    printf("Digite um caractere:\n");
    char c2 = getchar();
    while ((c = getchar()) != '\n' && c != EOF) { }
    printf("Digite um caractere:\n");
    char c3 = getchar();
    while ((c = getchar()) != '\n' && c != EOF) { }
    printf("Primeiro caractere: %c\nSegundo caractere: %c\nTerceiro caractere: %c\n", c1, c2, c3);
}

//https://pt.stackoverflow.com/q/452177/101
