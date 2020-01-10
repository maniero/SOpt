#include <stdio.h>

int main(void) {
    char cor[37] = "0PVPPVPVVVPPVPVVVVPVPPVPVPPVPVPVPPVPV";
    int entrada;
    printf("Qual é o número? ");
    scanf("%i", &entrada);
    if (entrada < 0 || entrada > 36) { 
        printf("Valor inválido");
        return 0;
    }
    printf("\nO número é %d, é %s", entrada, cor[entrada] == 'V' ? "vermelho" : cor[entrada] == 'P'
                                                                 ? "preto" : "verde");
    printf(", %s", entrada > 18 ? "grande" : "pequeno");
    printf(", %s", entrada % 2 == 0 ? "par" : "ímpar");
}

//https://pt.stackoverflow.com/q/128452/101
