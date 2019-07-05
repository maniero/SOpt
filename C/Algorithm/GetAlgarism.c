#include<stdio.h>

int main() {
    const char *RA = "19480685";
    int tamanho = strlen(RA);    
    int vetor[tamnho];
    for (int i = 0; i < tamanho; i++) vetor[i] = RA[i] + '0';
    for (int i = 0; i < strlen(RA); i++) printf ("%d\n", vetor[i]);
}

//https://pt.stackoverflow.com/q/395616/101
