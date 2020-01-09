#include <stdio.h>

int main() {
    int idade = 0, cont50 = 0, espantalho = 0;
    float peso = 0.0, altura = 0.0, md = 0.0, mdpeso = 0.0;
    for (int i = 1; i < 3; i++) {
        printf("\nDigite a sua idade :");
        scanf("%d", &idade);
        printf("Digite a sua altura :");
        scanf("%f", &altura);
        printf("Digite seu peso :");
        scanf("%f", &peso);
        if (idade > 50) cont50++;
        if (idade >= 10 && idade <= 20) md += altura / 2;
        if (peso < 40) espantalho++;
        mdpeso = (espantalho / 2.0) * 100;
    }
    printf("\nO total de pessoas com idade superior a 50 e %d", cont50);
    printf("\nA media das alturas de pessoas com idade entre 10 e 20 anos e %.1f", md);
    printf("\nA porcentagem de pessoas com peso inferior a 40 kg e %f porcento", mdpeso);
}

//https://pt.stackoverflow.com/q/127994/101
