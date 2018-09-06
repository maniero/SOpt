#include <stdio.h>

int main() {
    float salario;
    printf("informe o salario atual: ");
    scanf("%f", &salario);
    printf("informe o percentual de reajuste: ");
    int percentual;
    scanf("%d", &percentual);
    printf("o novo salario e:%f\n ", salario + (salario * (percentual / 100.0)));
}

//https://pt.stackoverflow.com/q/323755/101
