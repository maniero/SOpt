#include <stdio.h>

int main(void) {
	int posicao = 6; //posicao do bit (equivale ao 64)
	int valor = 0;
	valor |= 1 << posicao; //ligando o bit
	printf("Ligou o bit: %d\n", valor);
	int resultado = (valor >> posicao) & 1; //verificando valor do bit
	printf("O bit está: %d\n", resultado);
	valor &= ~(1 << posicao); //limpando o bit
	printf("Desligou o bit: %d\n", valor);
	resultado = (valor >> posicao) & 1; //verificando valor do bit
	printf("O bit está: %d\n", resultado);
	valor ^= 1 << posicao; //invertendo um bit
	printf("Inverteu o bit: %d\n", valor);
	valor |= 16; //ligando o bit pelo seu valor
	printf("Ligou o 4. bit: %d\n", valor);
}

//https://pt.stackoverflow.com/q/175345/101
