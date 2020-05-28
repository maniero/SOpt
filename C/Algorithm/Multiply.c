#include <stdio.h>

int main() {
    int X = 0, Y = 0, par = 0, impar = 1;
    printf("Insira o VALOR DE X: ");
    scanf("%d", &X);
    printf("Insira o VALOR DE Y: ");
    scanf("%d", &Y);
    if (Y <= X) {
        printf("X não pode ser maior que Y\n");
        return 0;
    }
    for (int cont = X; cont <= Y; cont++) {
        if (cont % 2 == 0) par += cont;
        else impar *= cont;
    }
    printf("A soma dos números pares nesse intervalo é %d\n", par);
    printf("A multiplicação dos números impares nesse intervalo é %d\n", impar);
}

//https://pt.stackoverflow.com/q/218612/101
