#include <stdio.h>

int main(){   
    float peso; 
    printf("Digite quantos quilos você coletou:\n");
    scanf("%f", &peso);
    printf("=================================================\n");
    printf("Você coletou: %f Kg.\n", peso);
    if (peso > 50) printf("A multa a ser paga, será de: R$%f\n", (peso - 50) * 4.0);
    else printf("Não será necessário pagar multa!\n");
}

//https://pt.stackoverflow.com/q/449345/101
