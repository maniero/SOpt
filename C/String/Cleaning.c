#include <stdio.h>

int main () {
    int x, y;
    scanf("%d", &x);
    scanf("%d", &y);
    if (x < y && x > 1 && x < 20 && y < 10000) {
         printf("%d", 1);
        for (int i = 2; i <= x; i++) printf(" %d", i);
        printf("\n%d", x + 1);
        for (int i = x + 2; i <= y; i++) printf(" %d", i);
    }
}

//https://pt.stackoverflow.com/q/271685/101
