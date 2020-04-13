#include <stdio.h>

int media(int vet[]) {
    int soma = 0; 
    for (int i = 0; i < 5; i++) soma += vet[i]; 
    return soma / 5; 
}

int main() {
    int vet[5] = {4, 2, 1, 6, 7};
    printf("%d", media(vet));
}

//https://pt.stackoverflow.com/q/445744/101
