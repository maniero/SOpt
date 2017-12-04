#include <stdio.h>

void MostraTodos(char memoria[][30]) {
    for (int i = 0; i < 3; i++) printf("%s\n", memoria[i]);
}

int main() {
    char memoria[3][30];
    for (int i = 0; i < 3; i++) {
        printf("Introduza o seu nome\n");
        scanf("%s", &memoria[i][0]);
    }
    MostraTodos(memoria);
}

//https://pt.stackoverflow.com/q/260041/101
