#include <stdio.h>
#include <string.h>

int main() {
    char nomes[3][15];
    strcpy(nomes[0], "palavra");
    strcpy(nomes[1], "palavraozzz");
    strcpy(nomes[2], "palavraozao");
    for (int i = 0; i < 3 ; i++) printf("%-20s\t1\n", nomes[i]);
}

//https://pt.stackoverflow.com/q/440945/101
