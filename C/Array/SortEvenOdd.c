#include <stdio.h>

int main() {
    int quantidade;
    scanf("%d", &quantidade);
    int par[quantidade], impar[quantidade], qtdePar = 0, qtdeImpar = 0;
    for (int i = 0; i < quantidade; i++)  {
    	int entrada;
        scanf("%d", &entrada);
        if (entrada % 2 == 0) par[qtdePar++] = entrada;
        else impar[qtdeImpar++] = entrada;
    }
    for (int i = 0; i < qtdePar; i++) {
        for (int j = i; j < qtdePar; j++) {
            if (par[i] > par[j]) {
                int aux = par[i];
                par[i] = par[j];
                par[j] = aux;
            }
        }
    }
    for (int i = 0; i < qtdeImpar; i++) {
        for (int j = i; j < qtdeImpar; j++) {
            if (impar[i] < impar[j]) {
                int aux = impar[i];
                impar[i] = impar[j];
                impar[j] = aux;
            }
        }
    }
    for (int i = 0; i < qtdePar; i++) printf("%d\n", par[i]);
    for (int i = 0; i < qtdeImpar; i++) printf("%d\n", impar[i]);
}

//https://pt.stackoverflow.com/q/262817/101
