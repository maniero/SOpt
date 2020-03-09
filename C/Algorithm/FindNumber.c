#include <stdio.h>
#include <string.h>

int main() {
	char binario[16][5] = {"0000","0001","0010","0011","0100","0101","0110","0111","1000","1001","1010","1011","1100","1101","1110","1111"};
	char nome[10];
	printf("Insira um valor\n");
	scanf("%s", nome);
	int contador = 0;
	for (; contador < 16 && strcmp(nome, binario[contador]) != 0; contador++);
	if (contador == 16) printf("Base inicial invalida"); //essa mensagem não faz sentido com o enunciado
}

//https://pt.stackoverflow.com/q/154725/101
