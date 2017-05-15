#include <stdio.h>

int distanciaCorrida(int inicio, int fim) {
    return fim - inicio;
}

int main() {
    int kminicial = 200000;
    int kmfinal = 207349;
    int distancia = distanciaCorrida(kminicial, kmfinal);
    printf("A distancia percorrida pelo carro foi de %d km", distancia);
}

//https://pt.stackoverflow.com/q/204831/101
