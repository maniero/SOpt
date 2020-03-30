#include<stdio.h>

int main(void) {
    for (int row = 0; row < 7; row++) {
        for (int column = 0; column < row; column++) printf("*");
        printf("\n");
    }
    printf("\n");
}

//https://pt.stackoverflow.com/q/171588/101
