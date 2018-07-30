#include <stdio.h>
#define TAM 3

void preencher(char *str, char letra) {
    for (int c = 0; c < TAM - 1; c++) str[c] = letra;
    str[TAM - 1] = 0;
    printf("%s", str);
}

int main(){
    char str[TAM], letra;
    scanf("%c", &letra);
    preencher(str, letra);
}

//https://pt.stackoverflow.com/q/317828/101
