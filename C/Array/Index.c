#include <stdio.h>

int main() {
    int numero[8] = {1, 2, 3, 4, 5, 6, 7, 8};
    printf("\nA distribuicao desses numeros em ordem inversa : ");
    for (int i = 7; i >= 0; i--) printf("\n--------\n%d", numero[i]);
}

//https://pt.stackoverflow.com/q/336064/101
