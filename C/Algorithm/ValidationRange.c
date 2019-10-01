#include <stdio.h>

int main() {
	int num = 1, primo;
	do {
	    printf("Informe um numero primo maior que 1:");
	    scanf("%d", &primo);
	} while (primo <= 1);
    if (primo % num == 0) {
        printf("Numero primo %d", primo);
    } else {
        printf("Numero não primo");
    }
}

//https://pt.stackoverflow.com/q/85562/101
