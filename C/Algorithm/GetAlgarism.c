#include<stdio.h>
#include<string.h>

int main() {
    const char *RA = "19480685";
    int tamanho = strlen(RA);    
    int vetor[tamanho];
    for (int i = 0; i < tamanho; i++) vetor[i] = RA[i];
    for (int i = 0; i < tamanho; i++) printf ("%c\n", vetor[i]);
}

//https://pt.stackoverflow.com/q/395616/101
