#include <stdio.h>
#define MAX 500

int main() {
	char text [MAX + 1];
	printf("Informe o texto (tamanho maximo %d caracteres:", MAX);
	fgets(text, sizeof(text), stdin);
	text[0] = '*';
	for (int i = 0; i <= MAX; i++) if (text[i] == ' ') text[i + 1] = '*';
	printf("\nO texto final e %s\n", text);
}

//https://pt.stackoverflow.com/q/88015/101
