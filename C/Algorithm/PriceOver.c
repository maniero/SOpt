#include <stdio.h>

int main(){   
    float peso, excesso; 
    printf("Digite quantos quilos você coletou:\n");
    scanf("%f", &peso);
    printf("=================================================\n");
    printf("Digite quantos quilos de excesso foram coletados:\n");
    scanf("%f", &excesso);
    printf("=================================================\n");
    float total = peso + excesso;
    printf("Você coletou: %f Kg.\n", total);
    if (total >= 50) printf("A multa a ser paga, será de: R$%f\n", total * 4);
    else printf("Não será necessário pagar multa!\n");
}

//https://pt.stackoverflow.com/q/449345/101
