#include <stdio.h>

struct pessoa {
    int notas[4];
};

void listar(struct pessoa pessoa) {
   	for (int i = 0; i < 4; i++) printf("\n--Nota %d: %d", i + 1, pessoa.notas[i]);
}

int main() {
    struct pessoa n1[10];
    for (int i = 0; i < 4; i++) {
        printf("\nDigite a nota:");
        scanf("%d", &n1[0].notas[i]);
    }
    listar(n1[0]);
}

#https://pt.stackoverflow.com/q/418425/101
