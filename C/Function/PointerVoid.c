#include <stdio.h>

void comeco_fim(void (*func1)(void), void (*func2)(void)) {
    printf("começo");
    func1();
    printf("texto");
    func2();
    printf("fim");
}

void funcao1() {
	printf("funcao1");
}

void funcao2() {
	printf("funcao2");
}
int main(void) {
	comeco_fim(funcao1, funcao2);
}

//https://pt.stackoverflow.com/q/88304/101
