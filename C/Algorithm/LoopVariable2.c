#include <stdio.h>
int main() {
    struct pessoas {
        int codTC; //codigo do consumidor para falar se é 1-Residencial 2-Comercial 3-Industrial
        int num; //numero do consumidor (vou colocar o numero referente ao cod para nao confundir)
        float kwh; //Quilowatt-hora
    };
    struct pessoas consumidor[16];
    float total, consumo1, consumo2;
    int i = 0;
    printf("Exercício desenvolvido considerando a tarifa do CIP - Contribuição Municipal\n");
    do {
        printf("\nDigite o numero do consumidor: ");
        scanf("%i", &consumidor[i].num);
        if (consumidor[i].num == 0) break;
        printf("\nTipo de consumidor, digite:\n1 - Residencial\n2 - Comercial\n3 - Industrial: ");
        scanf("%i", &consumidor[i].codTC);
        printf("\nDigite a quantidade de kWh consumidos durante o mes: ");
        scanf("%f", &consumidor[i].kwh);
        fflush(stdin);
        if (consumidor[i].codTC == 1) {
            printf("\nResidencial");
            total = consumidor[i].kwh * 0.3;
            consumo1 = consumidor[i].kwh; //isto não faz sentido mas deixei
        } else if (consumidor[i].codTC == 2) {
            printf("\nComercial");
            total = consumidor[i].kwh * 0.5;
            consumo2 = consumidor[i].kwh; //isto não faz sentido mas deixei
        } else if (consumidor[i].codTC == 3) {
            printf("\nIndustrial");
            total = consumidor[i].kwh * 0.7;
        }
        float totalT = total + 5.17;
        float media = consumo1 + consumo2 / 2; //isto não faz sentido mas deixei
        printf("\nO total de consumo e %.2f\n", total);
        printf("\nO custo total e %.2f\n", totalT);
        printf("\nA media de consumo dos consumidores 1 e 2 e %.2f\n", media);
        i++;
    } while (i == 16);
}

//https://pt.stackoverflow.com/q/87889/101
