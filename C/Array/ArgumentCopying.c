#include <stdio.h>

typedef struct {
    char array[16];
} Tipo;

void funcao(Tipo p) {
	printf("%d\n", sizeof(p));
	printf("%s", p.array);
}

int main(void) {
	Tipo dado = { .array = "teste de array" };
	funcao(dado);
}

//http://pt.stackoverflow.com/q/180326/101
