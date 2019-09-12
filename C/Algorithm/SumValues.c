#include <stdio.h>

int main() {
    int soma = 0;
    printf("Digite 10 numeros para somar:\n");
    for (int i = 0; i < 10; i++) {
  	    int num;
        printf("Digite a %d nota: ", i + 1);
        scanf("%d", &num);
        soma += num;
    }
    printf("\nSoma = %d : ", soma);
}

//https://pt.stackoverflow.com/q/76029/101
