#include <stdio.h>

int fatorial(int num) {
	if (num >= 0) {
	    int fat = 1;
	    while (num > 0) {
	        fat *= num;
	        num--;
	    }
	    return fat;
	} else {
	    return -1;
	}
}

int main() {
	int num;
	printf("ESTE POGRAMA CALCULA N FATORIAL = N!\n");
	printf("Digite um valor para ser calculado: ");
	scanf("%d", &num);
	int fat = fatorial(num);
	if (fat < 1) {
		printf("O calculo do fatorial se aplica somene aos numeros naturais.\n");
	} else {
	    printf("\n\tO fatorial de %d = %d\n\n", num, fat);
	}
}

//http://pt.stackoverflow.com/q/185619/101
