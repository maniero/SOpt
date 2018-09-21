#include <stdio.h>

unsigned long int fat(unsigned int n) {
    int fatorial = 1;
    for (int i = 1; i <= n; i++) fatorial *= i;
    return fatorial;
}

int main() {
    int numero;
    scanf("%d", &numero);
    printf("%d! =  %ld", numero, fat(numero));
}

//https://pt.stackoverflow.com/q/330965/101
