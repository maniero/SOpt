#include <stdio.h>
#include <locale.h>

int main() {
    setlocale(LC_ALL, "Portuguese");
    int idade, sup50 = 0, peso40 = 0, jovens = 0;
    float altura, peso, alturas;
    for (int i = 0; i < 25; i++) {
        printf("DIGITE A IDADE DA %d PESSOA: ", i + 1);
        scanf("%d", &idade);
        printf("DIGITE A ALTURA DA %d PESSOA: ", i + 1);
        scanf("%f", &altura);
        printf("DIGITE O PESO DA %d PESSOA: ", i + 1);
        scanf("%f", &peso);
        printf("\n");
        if (idade > 50) sup50++;
        if (idade >= 10 && idade <= 20) {
        	jovens++;
        	alturas += altura;
        }
        if (peso < 40) peso40++;
    }
    printf("\n\nA QUANTIDADE DE PESSOAS COM IDADE SUPERIOR Á 50 É %d\n\n", sup50);
    printf("A MÉDIA DAS ALTURAS DE PESSOAS ENTRE 10 E 20 ANO É %.2f\n\n", alturas / jovens);
    printf("A PORCENTAGEM DE PESSOAS COM PESO INFERIOR Á 40 KG É %.2f%%\n\n", peso40 * 4.0);
}

//https://pt.stackoverflow.com/q/335324/101
