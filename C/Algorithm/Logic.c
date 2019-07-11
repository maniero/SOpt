#include <math.h>
#include <stdio.h>

int main() {
    int num, aux, cont;
    aux = 0;
    printf("digite um nume:\n");
    scanf("%i", &num);
 	for (int i = num; i >= 2; --i) {
 		cont = 0;
		for (int j = 2; j < sqrt(i) + 1; ++j) {
			if (i % j == 0)	{
		        cont++;
                break;
			}
		}
		if (cont == 0) {
			aux = i;
			break;
		}
	}
	printf("O maior numero primo entre 0 e %d sera %d", num, aux);
}

//https://pt.stackoverflow.com/q/50491/101
