#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char *strShift(char *s) {
	int tam = strlen(s);
	char *nova = malloc(tam + 1);
	if (nova == NULL) return NULL;
	for (int i = 0; i < tam; i++) nova[i] = s[i] + 1;
    nova[tam] = '\0';
	return nova;
}

int main(void) {
	printf("%s", strShift("anaz"));
}

//https://pt.stackoverflow.com/q/448423/101
