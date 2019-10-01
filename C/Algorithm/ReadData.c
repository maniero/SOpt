#include <stdio.h>

struct tetris {
    char nome[16];
    int pontuacao;
};

int main() {
    int j = -1;
    while (scanf("%d", &j) && j != 0) { };
    struct tetris jogador[j];
    for (int i = 0; i < j; i++) {
        scanf("%15s", jogador[i].nome);
        printf("LI NOME\n");
        int total = 0;
        int maior = 0;
        int menor = 32767; //tem um risco aqui
        for (int k = 0; k <= 11; k++) {
        	int pontos = 0;
            scanf("%d", &pontos);
            printf("LI PONTO\n");
            total += pontos;
            if (pontos > maior) maior = pontos;
            else if (pontos < menor) menor = pontos;
            if (k == 0) menor = maior;
        }
        printf("\n");
        jogador[i].pontuacao = total - maior - menor;
    }
    printf("ACABEI\n");
    for (int k = 0; k < j; k++) printf("%s %d\n", jogador[k].nome, jogador[k].pontuacao);
}

//https://pt.stackoverflow.com/q/84070/101
