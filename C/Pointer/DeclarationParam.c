#include <stdio.h>

void funcao2(int *var) {
    printf("%d", *var);
}

void funcao1(int *var) {
    funcao2(var);
}

int main() {
    int valor;
    scanf("%d", &valor);
    funcao1(&valor);
}

//https://pt.stackoverflow.com/q/526911/101
