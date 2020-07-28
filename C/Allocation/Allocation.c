#include <stdio.h>
#include <limits.h>

int main() {
    int n;
    scanf("%d", &n);
    int x[n];
    int menor = INT_MAX;
    int posicao = 0;
    for (int i = 0; i < n; i++) { 
        scanf("%d", &x[i]);
        if (x[i] < menor) {
            menor = x[i];
            posicao = i;
        } 
    }   
    printf("Menor valor: %d Posicao: %d", menor, posicao);
}

//https://pt.stackoverflow.com/q/320115/101
