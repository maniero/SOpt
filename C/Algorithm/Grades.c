#include <stdio.h>

int main() {
    float notas[12], soma = 0;    
    int notasval = 0;
    for (int i = 0; i < 12; i++) {
        scanf("%f", &notas[i]);
        if (notas[i] >= 0.0 && notas[i] <= 10.0) {
            notasval++;
            soma += notas[i];
        }
    }
    printf("A quantidae de notas invalidas é: %i\nA média das notas validas é: %.2f\n", 12 - notasval, soma / notasval);
}

//https://pt.stackoverflow.com/q/411953/101
