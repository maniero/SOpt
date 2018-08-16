#include <stdio.h>
#include <string.h>

int main() {
	int idade = 0;
	printf("Hello! How old are you? ");
	scanf("%d\n", &idade);
	while (idade == 0) {
	    printf("\nAge cannot be 0 nor be decimal. Re-enter your age: ");
	    scanf("%d", &idade);
	}
	char nome[21];
	scanf(" %[^\n]s", nome);
	printf("\nHello %s, aged %d!\n", nome, idade);
}

//https://pt.stackoverflow.com/q/320255/101
