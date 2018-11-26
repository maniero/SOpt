#include <stdio.h>

int main() {
	float salario[10], valorDataBase;
	printf("Informe o percentual  de reajuste da data-base: \n");
	scanf("%f", &valorDataBase);
    for (int i = 0; i < 10; i++) {
        printf("Informe o seu salario atual:\n");
        scanf("%f", &salario[i]);
    }
    for (int i = 0; i < 10; i++) printf("Seu salario reajustado sera %f\n", salario[i] + salario[i] * valorDataBase / 100);
}

//https://pt.stackoverflow.com/q/345240/101
