#include <stdio.h>
#include <stdlib.h>
#include <math.h>

#define PI 3.14

void circunferenciaCirculo(double raio) { printf("Circunferência é %lf", raio * 2 * PI); }
void areaCirculo(double raio) { printf("Área  é %lf", pow(raio * PI, 2)); }
void volumeEsfera(double raio) { printf("Volume é %lf", 4.0/3.0 * PI * pow(raio, 3)); }

int main() {
    system("color 3");
    void (*calculo[3])(double raio) = {circunferenciaCirculo, areaCirculo, volumeEsfera};
    int sentinela = 0;
    while (sentinela != 4) {
        system("cls");
        printf("Opcoes de calculo\n\n1-Circunferencia de circulo\n2-Area de circulo\n3-Volume de esfera\n4-Sair\n\nOpcao:");
        scanf("%d", &sentinela);
        if (sentinela < 1 || sentinela > 4) {
            printf("Opcao invalida!\n");
            system("PAUSE");
            continue;
        }
        if (sentinela == 4) break;
        system("cls");
        printf("Digite o raio:");
        double raio = 0.0;
        scanf("%lf", &raio);
        calculo[sentinela - 1](raio);
    }
}

//https://pt.stackoverflow.com/q/312915/101
