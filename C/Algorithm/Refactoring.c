#include<stdio.h>

int main() {
    printf("Coloque um valor: ");
    int valor;
    scanf("%d", &valor);
    int resultado = 1;
    while (valor > 0) {
        resultado *= valor;
        valor--;
    }
    printf("O exponencial é: %d\n", resultado);
}

//https://pt.stackoverflow.com/q/237565/101
