#include <stdio.h>

int vetorPalavra(char str[10]) {
    for (int i = 0; i < 7; i++) if (str[i] == 'a' && str[i + 1] == 's' && str[i + 2] == 'a' ) return 1;
    return 0;
}
int main() {
    printf("%d", vetorPalavra("xdmasahkp"));
}

//https://pt.stackoverflow.com/q/500511/101
