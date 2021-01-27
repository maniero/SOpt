#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define SIZE 30

void invertStr(const char* source, char* target) {
	int size = strlen(source);
    for (int i = 0; i < size; i++) target[i] = source[size - i - 1];
    target[size + 1] = '\0';
}

int main(void) {
    char str[SIZE];
    char str2[SIZE];
    scanf("%29s", str);
    invertStr(str, str2);
    printf("%s | %s\n", str, str2);
    return EXIT_SUCCESS;
}

//https://pt.quora.com/Em-Linguagem-C-como-free-um-array-alocado-dinamicamente-fora-do-escopo-da-fun%C3%A7%C3%A3o-em-que-ele-foi-declarado/answer/Antonio-Maniero
