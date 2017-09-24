#include <stdio.h>
#include <string.h>
#include <ctype.h>

int validade(char *S) {
    int tamanho = strlen(S);
    if (tamanho <= 6 || tamanho >= 32) return 0;
    int maiuscula = 0, minuscula = 0, numero = 0;
    for (int i = 0; i < tamanho - 1; i++) {
        if (islower(S[i])) maiuscula = 1;
        else if(isupper(S[i])) minuscula = 1;
        else if(isdigit(S[i])) numero = 1;
        else return 0;
    }
    return maiuscula * minuscula * numero;
}

int main() {
    char S[40];
    fgets(S, 40, stdin);
    printf(validade(S) ? "Senha valida.\n" : "Senha invalida.\n");
}


//https://pt.stackoverflow.com/q/240042/101
