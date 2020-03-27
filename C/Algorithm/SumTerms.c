#include <stdio.h>

int main() {
    int a1, q, n, soma = 0;
    scanf("%d %d %d", &a1, &q, &n);
    for (int i = 0; i < n; i++) {
        printf("%d\n", a1);
        a1 *= q;
        soma += a1;
    }
    printf("%d\n", soma);
}

//https://pt.stackoverflow.com/q/441956/101
