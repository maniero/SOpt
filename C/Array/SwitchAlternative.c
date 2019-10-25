#include <stdio.h>

void telaAjuda1() {
	printf("f1");
}

void telaAjuda2() {
	printf("f2");
}

int main(void) {
	int opAjuda;
    scanf("%i", &opAjuda);
    void (*opcoes[])() = {&telaAjuda1, &telaAjuda2};
    (*opcoes[opAjuda - 1])();
}

//https://pt.stackoverflow.com/q/97604/101
