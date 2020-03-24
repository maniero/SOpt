#include <stdio.h>
#include <string.h>

int main(void) {
	char nomeString[] = "nomedoarquivo.txt";
	nomeString[strlen(nomeString) - 4] = '\0';
	printf("%s", nomeString);
}

//https://pt.stackoverflow.com/q/168134/101
