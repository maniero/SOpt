#include <stdio.h>
int main() {
    int vetor [9];
    int matriz [3][3];
    printf("Digite 9 número para uma matriz \n" );
    for (int i = 0; i < 9; i++) scanf("%i", &vetor[i]);
    for (int lin = 0, k = 0; lin < 3; lin++) {
        for (int col = 0; col < 3; col++, k++) {
            matriz[lin][col] = vetor[k];
            printf("%i\t", matriz[lin][col]);
        }
        printf("\n");
    }
}

//https://pt.stackoverflow.com/q/133847/101
