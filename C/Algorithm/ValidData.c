#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

#define tam_max 256

int recebe(char principal[tam_max]) {
    int erro = 0;
    setbuf(stdin, NULL);
    fgets(principal, tam_max, stdin);
    for (int i = 0; i < strlen(principal); i++) {
        if (principal[0] == '\n') {
            erro++;
        } else if ( principal[i] == '+' || principal[i] == '-' ||
            principal[i] == '*' || principal[i] == '/' ||
            principal[i] == '=' || principal[i] == '^' ||
            principal[i] == 'i' || principal[i] == 'p' ||
            principal[i] == '0' || principal[i] == '1' ||
            principal[i] == '2' || principal[i] == '3' || 
            principal[i] == '4' || principal[i] == '5' || 
            principal[i] == '6' || principal[i] == '7' ||
            principal[i] == '8' || principal[i] == '9' || principal[i] == '\n') {
            erro = 0;
        } else {
            erro++;
        }
    } 
    return erro;
}

void divide() {
    printf("OK ate aqui\n");
}

void validaDados() {
    int verifica = 0;
    char principal[tam_max];
    verifica = recebe(principal);
    printf("%s\n", principal);
    if (verifica > 0) {
        printf("\nCaracteres invalidos inseridos. Por favor, tente novamente.\n\n");
        validaDados();
    }
    if (verifica == 0) {
        divide();
    }
}

int main() {
    validaDados();
}

//https://pt.stackoverflow.com/q/154923/101
