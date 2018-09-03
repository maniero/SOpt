#include <stdio.h>

typedef struct {
    int Numerador;
    int Denominador;
} TNumeroRacional;

void Atribuir(TNumeroRacional *num, TNumeroRacional *num2, int numerador, int denominador) {
    printf(" a: Atribuir valores para os campos.\n");
    printf("Primeiro numero racional:");
    printf(" Por favor, insira os valores: \n Numerador: ");
    scanf("%d", &num->Numerador);
    printf(" Denominador: ");
    scanf("%d", &num->Denominador);
    printf("Segundo numero racional:");
    printf(" Por favor, insira os valores: \n Numerador: ");
    scanf("%d", &num2->Numerador);
    printf(" Denominador: ");
    scanf("%d", &num2->Denominador);
    printf("Numero racional 1: %d/%d \n", num->Numerador, num->Denominador);
}

int main(void) {
	int numerador = 0, denominador = 0;
	TNumeroRacional num, num2;
	Atribuir(&num, &num2, numerador, denominador);
}

//https://pt.stackoverflow.com/q/326722/101
