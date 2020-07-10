#include <stdio.h>

int main(void) {
    int numero = 1;
    int resultado = 0;
    while (numero < 65) resultado += numero++;
    printf("%d\n", resultado);
}

//https://pt.stackoverflow.com/q/276505/101
