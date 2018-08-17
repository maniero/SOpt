#include <stdio.h>

void validar(float *var) {
    while (1) {
        scanf("%f", var);
        if (*var >= 0 && *var <= 10) return;
        printf("\nNota invalida, tente novamente: ");
    }
}

int main() {
    float lab, avaliacao, exame;
    printf("Entre com a nota do trabalho de laboratorio: ");
    validar(&lab);
    printf("Entre com a nota da avaliação bimestral: ");
    validar(&avaliacao);
    printf("Entre com a nota do exame final: ");
    validar(&exame);
    float media = (lab * 2 + avaliacao * 3 + exame * 5) / (2 + 3 + 5);
    printf((media < 3) ? "\nAluno reprovado.\n" : (media < 5) ? "\nAluno em recuperação\n" : "\nAluno aprovado\n");
}

//https://pt.stackoverflow.com/q/323110/101
