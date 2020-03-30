#include <stdio.h>

static int externa = 1;

static void teste() {
    int x = 0;
    static int estatica = 0;
    x++;
    estatica++;
    printf("x = %d, estatica = %d, externa = %d\n", x, estatica, externa);
}
int main() {
	printf("externa = %d\n", externa);
    for (int i = 0; i < 10; i++) teste();
}

//https://pt.stackoverflow.com/q/171410/101
