#include <stdio.h>
#include <math.h>

void receber_matriz(int l, int c) {
    int M[l][c];
    for (int linha = 0; linha < l ; linha++) {
        for (int coluna = 0; coluna < c; coluna++) {
            printf ("\nInsira o valor do numero da linha: %d e da coluna: %d", linha, coluna);
            scanf ("%d", &M[linha][coluna]);
        }
    }
}

int main () {
    int l = 3;
    int c = 3;
    receber_matriz(l, c);
}

//https://pt.stackoverflow.com/q/91682/101

//https://pt.stackoverflow.com/q/91682/101
