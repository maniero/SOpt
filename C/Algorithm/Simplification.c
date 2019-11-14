#include <stdio.h>
int main() {
    printf("\t\tPrograma para saber quanto demora a tornar-se génio!\n\n");
    int num_horas;
    printf("Quantas horas vai dedicar por dia para ser genio?");
    scanf("%d", &num_horas);
    float dias = num_horas / 365;
    float anos = 10000 / dias;
    printf("Voce vai demorar %.0f dias ou seja aproximadamente %.0f anos\n%d meses para ficar genio\n", dias, anos, (anos - (int)anos) * 12);
}

//https://pt.stackoverflow.com/q/106372/101
