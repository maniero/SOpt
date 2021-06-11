#include <stdio.h>
#include <stdlib.h>

double calcSoma(int n);
long int fatorial(int n);

int main () {
    int termos;
do {
    printf("Digite a qtd de termos (>= 5): ");
    scanf("%d", &termos);
}while(termos < 5);
 printf("\nO somatorio para %d termos eh %e", termos, calcSoma(termos));

}

double calcSoma (int n){
    double s = 1;
    int i, numerador = 0, valFat = 1;
    for (i = 0; i < n; i ++) {
        numerador = numerador + 2;
        valFat = valFat + 2; //numeros impares
        s = s + (double)numerador/fatorial(valFat);
    }
return s;
}

long int fatorial(int n){
    long int fat = 0;
    if (n == 0) {
        return 1;
    }else {
        fat = n * (fatorial(n-1));
    }
    return fat;
}

//https://pt.stackoverflow.com/q/131399/101
