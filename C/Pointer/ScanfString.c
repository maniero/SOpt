#include <stdio.h>
#include <stdlib.h>
 
int main(void) {
	char txt[10];
	printf("%p\n", txt); //endereço do array
	printf("%p\n", &txt); //é a mesma coisa, por isso funciona
	scanf("%s", &txt);
	printf("%s\n\n", txt);
	char *txt2 = malloc(10);
	printf("%p\n", txt2); //aqui pega o local de armazenamento
	printf("%p\n", &txt2); //aqui pega o endereço da variável
	scanf("%s", &txt2);
//	printf("%s", txt2);  //quebra
}

//https://pt.stackoverflow.com/q/251918/101
