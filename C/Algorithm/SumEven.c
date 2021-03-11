#include <stdio.h>

int soma_matriz(int n, int mat[n][n]) {
    int soma = 0;
    for (int i = 0; i < n; i++) for (int j = 0; j < n; j++) if (i < j) soma += mat[i][j];
    return soma;
}

int main() {
    int mat[3][3] = {{1, 1, 1}, {1, 1, 1}, {1, 1, 1}};
    printf("O valor e %d", soma_matriz(3, mat));
}

//https://pt.stackoverflow.com/q/498855/101
