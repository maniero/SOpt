#include <stdio.h>

int EstaOrdemCrescente(int vetor[], int tamanho) {
    for (int i = 1; i < tamanho; i++) if (vetor[i - 1] > vetor[i]) return 0;
    return 1; 
 }
 
 int main() {
    printf(EstaOrdemCrescente((int[]){-1, 2, 3, 4, 5}, 5) ? "Esta em ordem crescente\n" : "Nao esta em ordem crescente\n");
    printf(EstaOrdemCrescente((int[]){-1, 2, 0, 4, 5}, 5) ? "Esta em ordem crescente\n" : "Nao esta em ordem crescente\n");
    printf(EstaOrdemCrescente((int[]){1}, 0) ? "Esta em ordem crescente\n" : "Nao esta em ordem crescente\n");
}

//https://pt.stackoverflow.com/q/334712/101
