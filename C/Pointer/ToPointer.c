#include <stdio.h>

int main(void) {
    int valor = 50;
    int *ponteiro = &valor;
    int **ponteiroDoPonteiro = &ponteiro;
    printf("\n%d", **ponteiroDoPonteiro);
}

//https://pt.stackoverflow.com/q/92823/101
