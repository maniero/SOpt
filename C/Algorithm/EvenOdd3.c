#include <stdio.h>

int main(void) {
    int num1, num2;
    printf("\nInforme os números: ");
    scanf("%i""%i", &num1, &num2);
    printf("\nO número %d é %s e é o número é o %s", num1, (num1 % 2 == 0 ? "par" : "impar"), (num1 > num2 ? "maior" : "menor"));
    printf("\nO número %d é %s e é o número é o %s", num2, (num2 % 2 == 0 ? "par" : "impar"), (num2 > num1 ? "maior" : "menor"));
}

//https://pt.stackoverflow.com/q/128460/101
