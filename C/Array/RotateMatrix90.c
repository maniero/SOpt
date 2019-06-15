#include <stdio.h>

int main (void) {
    int matriz[3][3], rot[3][3];
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            printf("Digite o valor da matriz[%d][%d]: ", i + 1, j + 1);
            scanf("%d", &matriz[i][j]);
        }
    }
    for (int i = 0; i < 3; i++) {
        printf("\n");
        for (int j = 0; j < 3; j++) printf(" %d ", matriz[i][j]);
    }
    for (int i = 0; i < 3; i++) for (int j = 2; j >= 0; j--) rot[i][j] = matriz[j][2 - i];
    printf("\nMATRIZ 90º");
    for (int i = 0; i < 3; i++) {
        printf("\n");
        for (int j = 0; j < 3; j++) printf(" %d ", rot[i][j]);
    }
}

//https://pt.stackoverflow.com/q/391441/101
