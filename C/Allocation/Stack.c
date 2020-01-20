#include <stdio.h>

void set() {
	char str[12] = "O rato roeu";
	printf("%s\n", str);
}

void show() {
	int x = 0;
	char vet[12];
//	printf("vet = '%s'\nx = %d", vet, x);
	printf("vet = '%s'\n", vet);
	printf("x = %d", x);
}

int main() {
	set();
	show();
}

//https://pt.stackoverflow.com/q/134177/101
