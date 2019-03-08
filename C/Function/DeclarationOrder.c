#include <stdio.h>

double Somar(double a, double b) {
    return a + b;
}

int main() {
    double a, b;
    printf ("Digite a: ");
    scanf("%lf", &a);
    printf ("Digite bi ");
    scanf("%lf", &b);
    printf("O resultado eh %lf", Somar(a, b));
}

//https://pt.stackoverflow.com/q/366060/101
