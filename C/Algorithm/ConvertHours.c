#include <stdio.h>

float converterDiasEmAnos(float dias) {
    return dias / 365;
}
float converterHorasEmDias(int horas) {
    return 10000 / horas;
}
int obterMeses(float anos) {
    return (anos - (int)anos) / (1.0f / 12.0f) + 1;
}
int main() {
    printf("\tPrograma para saber quanto demora a tornar-se genio!\n\n");
    int num_horas;
    printf("Quantas horas vai dedicar por dia para ser genio? ");
    scanf("%d", &num_horas);
    float dias = converterHorasEmDias(num_horas);
    float anos = converterDiasEmAnos(dias);
    int meses = obterMeses(anos);
    printf("\nVoce vai demorar %.1f dias, ou seja, aproximadamente %d anos e %d meses para ficar genio", dias, (int)anos, meses);
}

//https://pt.stackoverflow.com/q/106329/101
