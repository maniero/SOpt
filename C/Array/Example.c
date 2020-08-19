#include <stdio.h>

int main() {
    int vet[7] = {0};
    for (int i = 0; i < 7; i++) printf("%d ", vet[i]); //Mostrando todos os valores do vetor
    printf("\n\n");
    printf("%d\n\n", vet); //Mostrando o endereco de memoria do primeiro indice do vetor
    for (int i = 0; i < 7; i++) printf("%d ", (vet + i)); //Mostrando todos os endereco de memoria do vetor
    printf("\n\n");
    vet[5] = 1024; //Alterando o indice seis para 1024
    for (int i = 0; i < 7; i++) printf("%d ", vet[i]); //Exibindo todos os indices do vetor
    getchar();
}

//https://pt.stackoverflow.com/q/468291/101
