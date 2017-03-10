#include <stdio.h>

int main () {
    for (int i = 1; i < 3000; i++) {
        int numero = i;
        char *romanos[] = {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
        int arabicos[] = {1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};
        // acha a quantidade de elementos no array
        int indice = (sizeof(arabicos) / sizeof(arabicos[0])) - 1;
        while (numero > 0) {
            if (numero >= arabicos[indice]) {
                printf("%s", romanos[indice]);
                numero -= arabicos[indice];
            } else {
                indice--;
            }
        }
        printf("\n");
    }
}

//http://pt.stackoverflow.com/q/17054/101
