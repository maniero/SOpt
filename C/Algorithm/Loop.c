#include <stdio.h>  

int main() {
    int a, b;
    printf("Digite a: ");
    scanf("%d", &a);
    printf("Digite b: ");
    scanf("%d", &b);
    int soma = 0;
    for (int i = a; i <= b; i++) {
        soma += i;
        printf("%d ", soma);
    }
}

//https://pt.stackoverflow.com/q/298444/101
