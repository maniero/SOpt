#include <stdio.h>

typedef struct {
    int dia;
    int mes;
    int ano;
} data;

int main() {
    data data_aniversario[4];
    for (int i = 0; i < 4; i++) {
        printf("Preencha sua data de nascimento\n\n");
        printf("Digite o dia: ");
        scanf("%d", &data_aniversario[i].dia);
        printf("\n\nDigite o mes: ");
        scanf("%d", &data_aniversario[i].mes);
        printf("\n\nDigite o ano: ");
        scanf("%d", &data_aniversario[i].ano);
    }
    for (int i = 0;i < 4;i++) {
        printf("\n\nA data do seu aniversário é: \n");
        printf("%d/%d/%d\n", data_aniversario[i].dia, data_aniversario[i].mes, data_aniversario[i].ano);
    }
}

//https://pt.stackoverflow.com/q/40461/101
