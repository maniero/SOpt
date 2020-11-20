#include <stdio.h>

int main(void) {
	int i = 0;
	char c = 0;
	char *s = "teste";
	void *p = NULL;
	printf("%d %c %s %p\n", i, c, s, p);
	if (!c) printf("i ok\n"); //verifica se não é zero
	if (!c) printf("c ok\n"); //verifica se não é um caractere nulo
	if (!s[5]) printf("s ok\n"); //verifica se o 6o. caractere é o terminador
	if (!p) printf("p ok\n"); //verifica se o ponteiro não é nulo
//	if (p == i) printf("p NULL ok\n"); //tipos incompatíveis sendo comparados
        printf("%zu", sizeof('x'));
}

//http://pt.stackoverflow.com/a/177620/101
