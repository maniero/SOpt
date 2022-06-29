#include <stdio.h>

int main() {
    int mes;
    printf("Numero do mes: ");
    scanf("%d", &mes);
    if (mes < 1 || mes > 12) {
    	printf("Erro\n");
    	return -1;
    }
    printf("%s", (char *[12]){ "Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" }[mes - 1]);
}

//https://pt.stackoverflow.com/q/361599/101
