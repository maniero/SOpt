#include<stdio.h>

int param(int x) {
    return x + 10;
}

int main() {
    printf("Digite um numero: ");
    int x;
    scanf(" %d", &x);
    int y = param(x);
    printf("\nO valor de y e %d \n", y);
    printf("\nO valor de x e %d \n", x);
}

//https://pt.stackoverflow.com/q/493850/101
