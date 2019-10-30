#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main() {
    int PORTAS[] = {0, 0, 0};  // 0 - a porta contém uma cabra; 1 - a porta contém o carro 
    int ESTAT[] = {0, 0, 0};   // {Tentativas, vitórias, derrotas}
    int repeticoes;
    int DECISAO;
    printf("1 para trocar todas, 0 para manter todas: ");
    scanf ("%d", &DECISAO);
    printf ("Digite o número de repetições: "); // Recomendável 10, 100 ou 1000.
    scanf ("%d", &repeticoes);
    int NUM = repeticoes;
    do {
    	int AUX;
    	int CAR = rand () %3;   // Randomiza a porta que recebe o carro.
        PORTAS[CAR] = 1;   
        int ESC = rand () %3;   // Randomiza a escolha da porta.
        if (DECISAO == 1) {    // Se foi escolhido trocar todas as vezes.
            if (PORTAS[ESC] == 1 ) {   // Porta escolhida contém o carro.
                for (AUX = 0; AUX < 3 ; AUX++) {
                    if (PORTAS[AUX] != 1 && AUX != ESC) {
                        ESC = AUX;      //Mudança de porta
                        AUX = 3;    // Para quebrar o 'For'
                        ESTAT[2] += 1;
                    }
                }
            }
            if (PORTAS[ESC] == 0) {    //Porta escolhida contém uma cabra.
                ESC = CAR;  // Pois sendo a porta errada, e tendo a outra errada sido revelada, só sobrou a correta.
                ESTAT[1] += 1;
            }
        }
        if (DECISAO == 0) {     //Caso tenha sido escolhido manter todas as vezes.
            if (ESC == CAR ) ESTAT[1] += 1;
            else  ESTAT[2] += 1;
        }
        NUM--;
        ESTAT[0] += 1;
    } while (NUM > 0);
    float VIT = (ESTAT[2] / repeticoes) * 100; // Porcentagem de vitórias  *ERRO*
    float DER = (ESTAT[3] / repeticoes) * 100; // Porcentagem de derrotas  *ERRO*
    (DECISAO == 1) ? printf("\n\n\n\tTrocando de porta todas as vezes: \n\n") : printf("\n\n\n\tMantendo a porta todas as vezes: \n\n");
    printf("Número de tentativas: %d\n", ESTAT[0]);
    printf("Número de vitórias: %d, %f%% do total.\n", ESTAT[1], VIT);
    printf("Número de derrotas: %d, %f%% do total.", ESTAT[2], DER);
}

//https://pt.stackoverflow.com/q/100177/101
