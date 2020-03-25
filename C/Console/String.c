#include <stdio.h>
#include <stdlib.h>

int main() {
    char TextoUm[10]; //note a mudança aqui
    char *TextoDois = malloc(10); //note a mudança aqui
    printf("Digite um nome para \"TextoUm\":\n");
    scanf("%s", TextoUm);
    printf("O texto digitado foi: %s", TextoUm);
    printf("\nDigite um nome para \"TextoDois\":\n");
    scanf("%s", TextoDois);
    printf("O texto digitado foi: %s", TextoDois);
}

//https://pt.stackoverflow.com/q/168882/101
