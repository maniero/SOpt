#include <stdio.h>
#include <string.h>

int main(void) {
	char texto[] = "1234567890abcdefghijklm";
	int posicao = 15;
	int final = sizeof(texto) - posicao;
	char parte[final];
	memcpy(parte, &texto[posicao], final);
	printf("%s", parte);
}

//https://pt.stackoverflow.com/q/174759/101
