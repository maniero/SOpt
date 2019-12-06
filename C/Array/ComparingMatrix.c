#include <stdio.h>

int main() {
    int matriz[3][3];
    matriz[0][0] = 1;
    matriz[0][1] = 2;
    matriz[0][2] = 3;
    matriz[1][0] = 4;
    matriz[1][1] = 5;
    matriz[1][2] = 6;
    matriz[2][0] = 7;
    matriz[2][1] = 8;
    matriz[2][2] = 9;
    int coluna, linha, numero;
    printf("Digite um numero: ");
    scanf("%d", &numero);
    for (linha = 0; linha < 3; linha++) {
        for (coluna = 0; coluna < 3; coluna++) {
            if (numero == matriz[linha][coluna]) printf("\nA posicao do numero eh linha: %d e coluna: %d", linha, coluna);
        }
    }
    if (numero < 1 || numero > 9) printf("Nao encontrado!");
}

//https://pt.stackoverflow.com/q/113631/101
