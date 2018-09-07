#include <stdio.h>

int main() {
    int x;
    int y;
    printf ("Entre o numerador 'x' :\n");
    scanf ("%d", &x);
    printf ("Entre o denominador 'y' :\n");
    scanf ("%d", &y);
    printf("O resultado da divisao entre x e y, em formato ponto flutuante e : %f\n\n", (float)x / y);
}

//https://pt.stackoverflow.com/q/328113/101
