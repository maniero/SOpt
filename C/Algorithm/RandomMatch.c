#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
    char nomes[23][31];
    char itens[23][8];
    int contadorSalgado = 0, contadorDoce = 0, contadorBebida = 0;
    for (int i = 0; i < 23; i++) {
        printf("Digite o nome: ");
        scanf("%s", nomes[i]);
    }
    for (int i = 0; i < 23; i++) {
        while (1) {
            int sorteado = rand() % 3;
            if (sorteado == 0 && contadorSalgado < 11) {
                strcpy(itens[i], "salgado");
                contadorSalgado++;
                break;
            }
            else if (sorteado == 1 && contadorDoce < 6) {
                strcpy(itens[i], "doce");
                contadorDoce++;
                break;
            }
            else if (sorteado == 2 && contadorBebida < 6) {
                strcpy(itens[i], "bebida");
                contadorBebida++;
                break;
            }
        }
    }
    for (int i = 0; i < 23; i++) printf("Aluno: %s ficou com: %s\n", nomes[i], itens[i]);
}

//https://pt.stackoverflow.com/q/390782/101
