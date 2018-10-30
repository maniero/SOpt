#include <stdio.h>
#define QUANTIDADE 4

int main() {
    printf("#######################################");
    printf("\n           ANÁLISE DE FICHAS");
    printf("\n#######################################");
    int contaMulher = 0;
    float maiorAltura = 0, menorAltura = 999, somaMulher = 0, somaAltura = 0;
    for (int i = 0; i < QUANTIDADE; i++) {
        printf("\n ------------------------------------------------------------------");
        printf("\n (%d) - Qual seu gênero (1 - Masculino / 2 - Feminino): ", i + 1);
        int genero;
        scanf("%d", &genero);
        printf("\n (%d) - Insira sua altura: ", i + 1);
        float altura;
        scanf("%f", &altura);
        somaAltura += altura;
        if (genero == 2) {
        	somaMulher += altura;
        	contaMulher++;
        }
        if (altura > maiorAltura) maiorAltura = altura;
        if (altura < menorAltura) menorAltura = altura;
    }
    printf("\n****************************************************");
    printf("\n               R E S U L T A D O S");
    printf("\n****************************************************");
    printf("\n A média de altura das mulheres é: %0.1f", somaMulher / contaMulher);
    printf("\n A maior altura da turma é: %0.1f", maiorAltura);
    printf("\n A menor altura da turma é: %0.1f", menorAltura);
    printf("\n A média de altura da turma é: %0.1f", somaAltura / QUANTIDADE);      
}

//https://pt.stackoverflow.com/q/339215/101
