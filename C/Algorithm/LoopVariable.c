#include <stdio.h>
int main() {
    struct pessoas {
        int codTC; //codigo do consumidor para falar se é 1-Residencial 2-Comercial 3-Industrial
        int num; //numero do consumidor (vou colocar o numero referente ao cod para nao confundir)
        float kwh; //Quilowatt-hora
    };
    struct pessoas consumidor[16];
    float total, totalT, consumo1, consumo2;
    int i = 0;
    printf("\nExercício desenvolvido considerando a tarifa do CIP - Contribuição Municipal\n");
    do {
        printf("\nTipo de consumidor, digite:\n1 - Residencial\n2 - Comercial\n3 - Industrial: ");
        scanf("%i", &consumidor[i].codTC);
        fflush(stdin);
        if (consumidor[i].codTC == 1) {
            printf("\nResidencial");
            printf("\n\nDigite o numero do consumidor: ");
            scanf("%i", &consumidor[i].num);
            printf("\nDigite a quantidade de kWh consumidos durante o mes: ");
            scanf("%f", &consumidor[i].kwh);
            //O total do valor sem tarifa, ou seja o custo total para cada consumidor;
            total = consumidor[i].kwh * 0.3;
            //O total do valor com tarifa, ou seja o total + tarifas
            totalT = total + 5.17;
            consumo1 = consumidor[i].kwh;
        } else if (consumidor[i].codTC == 2) {
            printf("\nComercial");
            printf("\n\nDigite o numero do consumidor: ");
            scanf("%i", &consumidor[i].num);
            printf("\nDigite a quantidade de kWh consumidos durante o mes: ");
            scanf("%f", &consumidor[i].kwh);
            total = consumidor[i].kwh * 0.5;
            //O total do valor com tarifa, ou seja o total + tarifas
            totalT = total + 5.17;
            consumo2 = consumidor[i].kwh;
        } else if (consumidor[i].codTC == 3) {
            printf("\nIndustrial");
            printf("\n\nDigite o numero do consumidor: ");
            scanf("%i", &consumidor[i].num);
            printf("\nDigite a quantidade de kWh consumidos durante o mes: ");
            scanf("%f", &consumidor[i].kwh);
            total = consumidor[i].kwh * 0.7;
            //O total do valor com tarifa, ou seja o total + tarifas
            totalT = total + 5.17;
        }
        float media = consumo1 + consumo2 / 2;
        printf("\nO total de consumo e %.2f\n", total);
        printf("\nO custo total e %.2f\n", totalT);
        printf("\nA media de consumo dos consumidores 1 e 2 e %.2f\n", media);
        i++;
    } while (consumidor[i - 1].num != 0);
}

//https://pt.stackoverflow.com/q/87889/101
