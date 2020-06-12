#include <stdio.h>
#define DIM 2

void retorna_matriz2D(int mat[][DIM]) {
    for (int x = 0; x < DIM; x++) {
        for (int y = 0; y < DIM; y++) {
            mat[x][y] = 2;
            printf("%d\n", mat[x][y]);
        }
    }
}

int main(){
    int mat2D[DIM][DIM];
    retorna_matriz2D(mat2D);
    for (int x = 0; x < DIM; x++) for (int y = 0; y < DIM; y++) printf("%d\n", mat2D[x][y]);
}

//https://pt.stackoverflow.com/q/235989/101
