#include <stdio.h>

typedef struct {
	int a;
	int b;
	int c;
	char d;
	char e[10];
} Tipo;

int main(void) {
	Tipo obj = { 0, 1, 0, '\0', "x" }; //opção melhor
	printf("%s", obj.e);
	Tipo obj2 = { .b = 1, .e = "x" }; //não inicializa a, c e d
	printf("%s", obj2.e);
	Tipo obj3;
    obj3 = (Tipo){ .b = 1, .e = "x" };
	printf("%s", obj3.e);
}

//http://pt.stackoverflow.com/a/177877/101
