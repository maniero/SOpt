#include <stdio.h>

int main(void) {
	int valor = 0;
	scanf("%d", &valor);
	switch (valor) {
	case 0: {
	    int variavel = 1;
		printf("%d", variavel);
	    break;
	} default: {
	    int variavel = 2;
		printf("%d", variavel);
	}
	}
}

//https://pt.stackoverflow.com/q/176163/101
