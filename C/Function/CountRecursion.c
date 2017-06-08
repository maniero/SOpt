#include <stdio.h>
#define MAX 30

int ocorrencias(char palavra[], char letra, int i) {
	if (palavra[i] == '\0') return 0;
	return (letra == palavra[i]) + ocorrencias(palavra, letra, i + 1);
}

int main() {
	char palavra[MAX];
	char letra;
	scanf("%s %c", palavra, &letra);
	printf("%d", ocorrencias(palavra, letra, 0));
}

//https://pt.stackoverflow.com/q/211189/101
