#include <stdio.h>
#include <stdlib.h>
#include<time.h>

void aleatorio(int niv) {
	int aleat = (rand() % niv) + 1;
	int tent = -1;
	while (aleat != tent) {
	    printf("Digite o numero secreto");
	    scanf("%d", &tent);
	}
	printf("parabéns voce acertou!!\n");
}

int main() {
    srand((unsigned)time(NULL));
	int niv, res = -1;
    printf("Digite o numero limite: ");
    scanf("%d", &niv);
    while (res != 0) {
	    aleatorio(niv);
	    printf("Deseja jogar novamente? (0 - Não 1 - Sim)");
	    scanf("%d", &res);
    }
}

//https://pt.stackoverflow.com/q/408654/101
