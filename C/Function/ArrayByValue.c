#include <stdio.h>

typedef struct {
    unsigned int array[2];
} Valor;

void teste(Valor valor) {
	printf("%p, %d", (void *)&valor, valor.array[0]);
}

int main(void) {
	Valor valor;
	valor.array[0] = 10;
	printf("%p, %d", (void *)&valor, valor.array[0]);
	teste(valor);
}

//https://pt.stackoverflow.com/q/581809/101
