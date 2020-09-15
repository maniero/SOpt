#include <stdio.h>
#include <stdlib.h>

#define linhas 4
#define colunas 2

void teste1(float * t1, int totalLinhas, int totalColunas) {
    for (int i = 0; i < totalLinhas* totalColunas; i++) printf("%f\t", *((t1 + (i % totalLinhas) * totalColunas) + (i / totalLinhas)));
}
int main() {
    float t1[linhas][colunas];
    for (int i = 0; i < linhas * colunas; i++) t1[i % linhas][i / linhas] = i + 1;
    teste1((float *)t1, linhas, colunas);
    getchar();
}

//https://pt.stackoverflow.com/q/43948/101
