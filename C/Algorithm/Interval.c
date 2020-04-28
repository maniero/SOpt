#include <stdio.h>

int main() {
    int n1, n2;
    printf("Para saber os inteiros entre dois numeros siga os passos abaixo: \n");
    printf("Digite o primeiro numero: ");
    scanf("%d", &n1);
    printf("Digite o segundo numero: ");
    scanf("%d", &n2);
    if (n1 == n2) printf("NUMEROS IGUAIS!\n");
    else if (n1 < n2) while (n1 <= n2) printf("%d\n", n1++);
    else while (n1 >= n2) printf("%d\n", n1--);
}

//https://pt.stackoverflow.com/q/448669/101
