#include <stdio.h>
#include <math.h>

int main() {
    char operacao;
    printf("Escolha a opecaracao que deseja realizar: "); 
    scanf("%c", &operacao);
    switch (operacao) {       
    case '+': {
        int n1, n2;
        printf("\nInsira N1: "); scanf("%d", &n1);
        printf("\nInsira N2: "); scanf("%d", &n2);
        printf("\n%d + %d = %d", n1, n2, n1 + n2);
    break;
    } case '-': {
        int n1, n2;
        printf("\n Insira N1: "); scanf("%d", &n1);
        printf("\n Insira N2: "); scanf("%d", &n2);
        printf("\n %d - %d = %d", n1, n2, n1 - n2);
    break;
    } case '*': {
        int n1, n2;
        printf("\n Insira N1: "); scanf("%d", &n1);
        printf("\n Insira N2: "); scanf("%d", &n2);
        printf("\n %d X %d = %d", n1, n2, n1 * n2);    
    break;
    } case '/': {
        int n1, n2;
        printf("\n Insira N1: "); scanf("%d", &n1);
        printf("\n Insira N2: "); scanf("%d", &n2);
        printf("\n %d / %d = %.2f", n1, n2, (float)n1 / n2);
    break;
    }
    }
}

//https://pt.stackoverflow.com/q/332677/101
