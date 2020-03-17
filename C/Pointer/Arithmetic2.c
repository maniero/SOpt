#include <stdio.h>

int main() {
    int x = 1;
    x++;
    int *y = &x;
    y++;
    printf("%d, %d\n", x, *y);
    int z = 5;
    printf("%d, %d\n", z, *y);
}

//https://pt.stackoverflow.com/q/161038/101
