#include <stdio.h>

float dobro_do_maior(float x, float y) {
    return x > y ? x * 2 : y * 2;
}

int main() {
    float a, b;
    printf("Digite dois numeros: ");
    scanf("%f", &a);
    scanf("%f", &b);
    printf("o dobro é %f\n", dobro_do_maior(a, b));
}

//https://pt.stackoverflow.com/q/345773/101
