#include <stdio.h>

int main() {   
    double nota1, nota2;
    printf("Escreva a nota 1: ");
    scanf("%lf", &nota1);
    printf("\nEscreva a nota 2: ");
    scanf("%lf", &nota2);
    printf("\nA media ponderada e: ");
    printf("%.2lf", (nota1 * 2 + nota2 * 3) / 5);
}

//https://pt.stackoverflow.com/q/411447/101
