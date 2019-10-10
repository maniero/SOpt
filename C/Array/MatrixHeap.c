#include<stdio.h>
#include <stdlib.h>
void print(int *matriz, int lin, int col) {
    for (int i = 0; i < lin; i++) {
        for (int j = 0; j < col; j++) printf("%d, ", *(matriz + i * col + j));
    }
}

int main() {
    int * a = malloc(9 * sizeof(int));
    print(a, 3, 3);
}

//https://pt.stackoverflow.com/q/87638/101
