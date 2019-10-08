#include <stdio.h>

int main() {
    int x = 0, y = 0;
    scanf("%d", &x);
    scanf("%d", &y);
    int somaPares = x + y;
    int multiImpares = x * y;
    printf("%d\n", somaPares);
    printf("%d\n", multiImpares);
    while (x < y) {
        x++;
        if (x % 2 == 0) somaPares += x;
        else multiImpares *= x;
    }
    printf("A soma de X e Y mais os números pares entre eles é: %d\n", somaPares);
    printf("A multiplicação de X e Y mais os números ímpares entre eles é: %d", multiImpares);
}

//https://pt.stackoverflow.com/q/87541/101
