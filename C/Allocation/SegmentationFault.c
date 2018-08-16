#include <stdio.h>
#include <stdlib.h>

void newmap(int x, int y , int players) {
    char **map = malloc(sizeof(char *) * y);
    for (int i = 0; i < x; i++) {
        map[i] = malloc(x);
        for (int j = 0; j < y; j++) {
            if (i == 0 || j == 0 || i == x - 1 || j == y - 1) {
               map[i][j] = '*';
               printf("*");
            }
        }
        printf("\n");
    }
}

int main(void) {
    newmap(3, 3 , 3);
}

//https://pt.stackoverflow.com/q/322134/101
