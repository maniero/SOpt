#include <stdio.h>

int main(void) {
   int X[10];
   int cont = 0;
   while (cont < 10) {
        printf("Digite um numero inteiro: ");
        scanf("%d", &X[cont]);
        X[cont] = X[cont] % 2;
        cont++;
    }
    cont = 0;
    while (cont < 10) printf(" %d ", X[cont++]);
}

//https://pt.stackoverflow.com/q/460115/101
