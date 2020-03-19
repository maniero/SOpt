#include <stdio.h>

#define constante 0

void funcao() {
    int variavel = constante;
    static int estatica = constante;
    variavel++;
    estatica++;
    printf("variavel = %d, estatica = %d\n", variavel, estatica);
}

int main() {
    for (int i = 0; i < 10; ++i) funcao();
}

//https://pt.stackoverflow.com/q/164808/101
