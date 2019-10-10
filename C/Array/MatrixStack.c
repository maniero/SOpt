#include<stdio.h>
void print(int matriz[][3], int lin, int col) {
    for (int i = 0; i < lin; i++) {
        for (int j = 0; j < col; j++) printf("%d, ", matriz[i][j]);
    }
}

int main() {
    int a[3][3] = {{0}};
    print(a, 3, 3);
}

//https://pt.stackoverflow.com/q/87638/101
