#include <stdio.h>

int simpleArraySum(int array[6]) {
    int soma = 0;
    for (int i = 0; i < 6; i++) soma += array[i];
    return soma;
}

int main(void) {
    printf("%d", simpleArraySum((int[]){1, 2, 3, 4, 10, 11}));
}

//https://pt.stackoverflow.com/q/448758/101
