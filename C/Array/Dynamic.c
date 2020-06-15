#include <stdio.h>

void exibe (int *m, int n) {
    for (int i = 0; i < n; i++) printf("Numero %d = %d \n", i, m[i]);
}

int main() {
    int n;
    printf("Digite o numero de elementos do array : ");
    scanf("%d", &n);
    int m[n];
    for (int i = 0; i < n; i++) {
        printf("Digite o %d numero : ",i + 1);
        scanf("%d", &m[i]);
    }
    exibe(m, n);
}

//https://pt.stackoverflow.com/q/457318/101
