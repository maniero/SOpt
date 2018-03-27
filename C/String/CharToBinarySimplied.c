#include <stdio.h>
#include <stdlib.h>
#include <math.h>

void BinFormat(char character, char *text) {
    text[8] = '\0';
    for (int i = 7; i >= 0; i--) {
    	int divisor = (int)pow(2, i); //base 2 elevado à posição que está para achar o divisor
    	printf("[%d, ", divisor);
    	int cabe = character / divisor; //acha quantas unidades cabem no divisor
    	printf("%d, ", cabe);
    	int impar = (cabe % 2 != 0); //o que cabe é impar?
    	printf("%d] ", impar);
    	text[i] = impar + '0'; //transfoprma um número em caractere de acordo com a tabela ASCII
    }
}

int main(void) {
    char *text = malloc(9);
    BinFormat('A', text);
    printf("%s\n", text);
    BinFormat('B', text);
    printf("%s\n", text);
    BinFormat('C', text);
    printf("%s\n", text);
}

//https://pt.stackoverflow.com/q/286742/101
