#include<stdio.h>

int main() {
    float hora;
    printf("Insira as horas formatada 0.00: ");
    scanf("%f", &hora);
    float min = hora;
    hora = (int)hora;
    min = (min - hora) * 100;
    hora = hora * 60 + min;
    printf("%2.0f minutos", hora);
}

//http://pt.stackoverflow.com/q/195780/101
