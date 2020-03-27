#include <stdio.h>

int main() {
	//o DirecaoLast é só para determinar o final
    typedef enum direcao { Norte, Sul, Leste, Oeste, DirecaoLast } Direcao;
    const char* DirecaoNames[] = { "Norte", "Sul", "Leste", "Oeste" };
    for (int i = 0; i < DirecaoLast; i++) {
        Direcao direcao = i;
        printf("%s = %d\n", DirecaoNames[i], direcao);
    }
}

//https://pt.stackoverflow.com/q/170807/101
