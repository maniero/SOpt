#include <stdio.h>

int funcao() { printf("ok"); return 0; }
int funcao2(void) { printf("ok"); return 0; }
int main(void) {
	funcao(1, 2);
	funcao2(1, 2);
}

//https://pt.stackoverflow.com/q/138582/101
