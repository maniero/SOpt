#include <stdio.h>

int main() {
    int num1, num2;
    scanf("%d", &num1);
    scanf("%d", &num2);
    if (num1 > num2) {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    int multiplo = (num2 / num1) * num1;
    if (multiplo <= num2) printf("%d\n", multiplo);
    else printf("sem multiplos menores que %d", num2);
}

//https://pt.stackoverflow.com/q/393490/101
