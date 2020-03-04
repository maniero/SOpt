#include <stdio.h>

int main(void) {
	char array[] = { 65, 66, 67, 0 }; //o 0 é o terminador de string
	char string[] = "ABC";
	printf("%s\n", array); //está imprimindo os itens como string
	printf("%d, ", string[0]); //imprime cada byte da string
	printf("%d, ", string[1]);
	printf("%d", string[2]);
}

//https://pt.stackoverflow.com/q/153158/101
