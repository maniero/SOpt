#include <stdio.h>

int soma(int n1, int n2) {
    int soma = 0;
    for (int i = n1; i < n2; i++) soma += i; 
    return soma; 
}
int main() {
    int a, b; 
    printf("Digite dois numeros:");
    scanf("%d %d",&a,&b);
    printf("\nSoma = %d", soma(a, b));
}

//https://pt.stackoverflow.com/q/384958/101
