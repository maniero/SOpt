#include <stdio.h>

int main(void) {
    int inteiro = 3;
    int tamanho = sizeof(int) * 8;
    char binario[tamanho + 1];
    int i = tamanho - 1;
    while (i > 0) {
        binario[i] = inteiro % 2 + 48;
        inteiro /= 2;
        i--;
    }
    binario[tamanho] = '\0';
    printf("%s", binario);
}

//https://pt.stackoverflow.com/q/83420/101
