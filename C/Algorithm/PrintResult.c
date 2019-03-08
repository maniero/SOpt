#include <stdio.h>

int main(void) {
    int quantidade;
    scanf("%d", &quantidade);
    printf("Preço: %lf", quantidade * (quantidade < 12 ? 1.3 : 1.0));
}

//https://pt.stackoverflow.com/q/366396/101
