#include <stdio.h>

int main() {
    int vetor[4][3] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {10, 11, 12}};
    printf("%d", vetor[1][0] + 1 + vetor[3][0]);
}

//https://pt.stackoverflow.com/q/332158/101
