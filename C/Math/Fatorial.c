#include <stdio.h>

int fatorial(int n) {
    int resultado = 1;
    while (n > 1) resultado *= n--;
    return resultado;
}
int main(void) {
    int n;
    printf("Digite o numero a ser fatorado:\n");
    scanf("%d", &n);
    printf("%d", fatorial(n));
}

//https://pt.stackoverflow.com/q/333871/101
