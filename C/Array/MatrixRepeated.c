#include <stdio.h>

int repetido(int iMat[4][4], int i, int j) {
    for (int k = 0; k <= i; k++) {
        for (int l = 0; l < j; l++) {
            if (iMat[i][j] == iMat[k][l]) {
                printf("\nNúmero repetido, digite outro: \n");
                return 1;
            }
        }
    }
    return 0;
}

int main() {
    int iMat[4][4];
    printf("Digite 16 números diferentes para completar a matriz 4x4:\n");
    for (int i = 0; i < 4; i++) {
        for (int j = 0; j < 4; j++) {
            while (1) {
                printf("%i%i -> ", i, j);
                scanf("%i", &iMat[i][j]);
                if (!repetido(iMat, i, j)) break;
            }
        }
    }
    printf("\n");
    for (int i = 0; i < 4; i++) {
        for (int j = 0; j < 4; j++) printf("%2i ", iMat[i][j]);
        printf("\n");
    }
}

//https://pt.stackoverflow.com/q/278848/101
