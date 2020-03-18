#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>
#include <string.h>

double calculoQtIteracao(double raizA, double raizB, double testeParada) {
    return round((log10(raizB - raizA) - log10(testeParada)) / log10(2));
}

double calculoC(double raizA, double raizB) {
     return (raizA + raizB) / 2;
}

double calculoModuloAB(double raizA, double raizB) {
    return abs(raizA - raizB);
}

double calculoFxF(double raizA, double resultC){
    return (pow(raizA, 3) - 3 * raizA - 1) * (pow(resultC, 3) - 3 * resultC - 1);
}

char verificacaoSinal(double resultFxF){
    return resultFxF < 0 ? '-' : '+';
}

double trocaAB(double raizA, double raizB, double resultC, char verificacaoSinal) {
    return verificacaoSinal == '+' ? resultC : raizA;
    //o código aqui estava todo errado, isso ainda está errado, mas é o que executaria
}

void painelPerguntas() {
    double raizA = 0, raizB = 0, testeParada = 0;
    printf("RAIZ [a]: ");
    scanf("%lf", &raizA);
    fflush(stdin);
    printf("RAIZ [B]: ");
    scanf("%lf", &raizB);
    fflush(stdin);
    printf("PARADA: ");
    scanf("%lf", &testeParada);

    double qtIteracoes = calculoQtIteracao(raizA, raizB, testeParada);
    double resultC = calculoC(raizA, raizB);
    double resultAB = calculoModuloAB(raizA, raizB);
    double resultFxF = calculoFxF(raizA, resultC);
    char resultSinal = verificacaoSinal(resultFxF);
    double resultTrocaAB = trocaAB(raizA, raizB, resultC, resultSinal);

    printf("\n    N        |    A        |    B         |    C         |   |A-B|        |    F(A).F(C)       |  SINAL");
    //o problema estava aqui, falta declarar os vetores
    double vetorA[(int)qtIteracoes + 1];
    double vetorB[(int)qtIteracoes + 1];
    double vetorC[(int)qtIteracoes + 1];
    double vetorAB[(int)qtIteracoes + 1];
    double vetorFxF[(int)qtIteracoes + 1];
    char vetorSinal[(int)qtIteracoes + 1];
    //isso também não faz sentido no momento
    for (int cont = 0; cont <= qtIteracoes; cont++) {
        vetorA[cont] = resultTrocaAB;
        vetorB[cont] = resultTrocaAB;
        vetorC[cont] = resultC;
        vetorAB[cont] = resultAB;
        vetorFxF[cont] = resultFxF;
        vetorSinal[cont] = resultSinal;
        printf("\n%d %f %f %f %f %f %c", cont, vetorA[cont], vetorB[cont], vetorC[cont], vetorAB[cont], vetorFxF[cont], vetorSinal[cont]);
    }
}

int main(){
    painelPerguntas();
}

//https://pt.stackoverflow.com/q/163727/101
