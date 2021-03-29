#include <stdio.h>
int detecta(char letra) {
    if (letra >= 'A' && letra <= 'Z') return 1;
    else return (letra >= 'a' && letra <= 'z') - 1;
}

int main() {
    char letra;
    printf("Programa que detecta se a letra e maiuscula e ou minuscula");
    printf("\nDigite uma letra: ");
    scanf("%c", &letra);
    int x = detecta(letra);
    if (x == 0) printf("\nA letra digitada e minuscula!");
    else if (x == 1) printf("\nA letra digitada e maiscula!");
    else if (x == -1) printf("\nA letra digitada não pertence ao alfabeto");
}

//https://pt.stackoverflow.com/q/502606/101
