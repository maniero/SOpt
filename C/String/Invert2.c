#include <stdio.h>
#include <string.h>

int main(void) {
	char buffer[] = "Hello";
	size_t size = strlen(buffer);
	for(int i = 0; i < size / 2; i++) {
	   char tmp = buffer[i]; //armazena o character inicial
	   buffer[i] = buffer[size - i - 1]; //Troca o character da ponta oposta
	   buffer[size - i - 1] = tmp; //Armazena o character inicial no buffer
	}
	printf("%s", buffer);
}

//https://pt.stackoverflow.com/q/138315/101
