#include <stdio.h>

int main () {
    for (float F = 50; F <= 150; F++) {
        printf("--------------------------------\n");
        printf("Farenheit = %.0f\nConvertido para centígrados = %.2f\n", F, (5.0f / 9.0f) * (F - 32.0f));
    }
}
//http://pt.stackoverflow.com/q/195516/101
