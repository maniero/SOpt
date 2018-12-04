#include <stdio.h>

int func(int n) {
    return n == 0 ? 1 : func(n - 1) - n;
}

int main() {
    int a;
    printf("Digite um valor inteiro: ");
    scanf("%d", &a);
    printf("%d\n", func(a));
    int n = a;
    int temp = 1;
    while (1) {
    	temp -= n;
    	n--;
    	if (n == 0) break;
    }
    printf("%d\n", temp);
}

//https://pt.stackoverflow.com/q/347752/101
