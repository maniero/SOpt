#include <stdio.h>

int main () {
    int quantidade = 0, maior = 0;
    printf("Ao finalizar, digite '00', sem aspas, para obter o resultado.\n\n");
    while (1) {
        printf("Insira um numero: ");
        int num;
        scanf("%d", &num);
        if (!num) break;
        if (num > maior) {
            maior = num;
            quantidade = 1;
        } else if (num == maior) quantidade++;
    }
    printf("Maior numero: %d - quantidade de vezes: %d\n", maior, quantidade);
}

//https://pt.stackoverflow.com/q/485751/101
