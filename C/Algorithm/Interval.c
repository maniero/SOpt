#include <stdio.h>

int main() {
	int n1, n2;
    printf("Para saber os inteiros entre dois numeros siga os passos abaixo: \n");
    printf("Digite o primeiro numero: ");
    scanf("%d", &n1);
    printf("Digite o segundo numero: ");
    scanf("%d", &n2);
    if (n1 == n2) printf("NUMEROS IGUAIS!\n");
    else if (n1 < n2) for (int i = n1; i <= n2; i++) printf("%d\n", i);
    else  for (int i = n1; i >= n2; i--) printf("%d\n", i);
}

//https://pt.stackoverflow.com/q/448669/101
