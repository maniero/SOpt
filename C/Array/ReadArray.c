#include <stdlib.h>
#include <stdio.h>

void LeiaDadosDasEmpresas(int quantEmpresas, char ** nomeEmpresas) {
    for (int i = 0; i < quantEmpresas; i++) {
        printf("\nDigite o nome da %dª empresa: ", i + 1);
        scanf("%s", nomeEmpresas[i]);
    }
}
int main() {
    int quantEmpresas;
    char ** nomeEmpresas;
    printf("Digite o numero de empresas que queira analisar: ");
    scanf("%d", &quantEmpresas);
    nomeEmpresas = malloc(quantEmpresas * sizeof(char *));
    for (int i = 0; i < quantEmpresas; i++) nomeEmpresas[i] = malloc(21);
    LeiaDadosDasEmpresas(quantEmpresas, nomeEmpresas);
    for (int i = 0; i < quantEmpresas; i++) printf("\nNome da %dª empresa: %s", i + 1, nomeEmpresas[i]);
}

//https://pt.stackoverflow.com/q/107217/101
