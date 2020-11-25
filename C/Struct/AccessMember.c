#include <stdio.h>
#define SEMANA 7
#define TAM 1

typedef struct {
    int id;
    char nome[101];
    float horasTrab;
    float salarioHora;
    float horasExtra[SEMANA];
    float valorExtra;
} Funcionario;

void lerHoraExtra(Funcionario *funcionario) {
    printf("Considere que a semana comece na segunda-feira(dia 1)\n");
    for (int i = 0; i < SEMANA; i++) {
        printf("\nInforme quantas horas extra o funcionario fez no dia %d: ", i + 1);
        scanf("%f", &funcionario->horasExtra[i]);
    }
}

int main(void) {
	Funcionario funcionarios[TAM];
	lerHoraExtra(&funcionarios[0]);
    for (int i = 0; i < SEMANA; i++) printf("\n%f", funcionarios[0].horasExtra[i]);
}

//https://pt.stackoverflow.com/q/483752/101
