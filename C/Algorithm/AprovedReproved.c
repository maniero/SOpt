#include <stdio.h>
int main() {
    int auxa = 0, auxr = 0, notas = 0, cont = 0;
    while (cont < 10) {
        printf("digite o resultado: ");
        scanf("%i", &notas);
        if (notas == 1)
            auxa++;
        if (notas == 2)
            auxr++;
        if (notas != 1 && notas != 2)
            continue;
        cont++;
    }
    printf("aprovados:%i\n", auxa);
    printf("reprovados:%i\n", auxr);
    if (auxa >= 8)
        printf("bonus ao instrutor\n");
    if (auxr >= 7)
        printf("algo esta errado com o instrutor\n");
}

//http://pt.stackoverflow.com/q/22562/101
