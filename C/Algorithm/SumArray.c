#include <stdio.h>

int main() {
    int apols[5] ,apolsTotal = 0;
    for (int i = 0; i < 5; i++){
        printf("Digite a sua nota da apol %d\n", i + 1);
        scanf("%d", &apols[i]);
        apolsTotal += apols[i];
    }
    printf("Total: %d\n", apolsTotal);
}

//https://pt.stackoverflow.com/q/333979/101
