#include <stdio.h>

int main() {
    float alunos[5];
    float soma = 0;
    for (int i = 0; i < 5; i++) {
        scanf("%f", &alunos[i]);
        soma += alunos[i];
    }
    float media = soma / 5;
    for (int i = 0; i < 5; i++) if (alunos[i] >= media) printf("%.2f\n", alunos[i]);
}

//https://pt.stackoverflow.com/q/508521/101
