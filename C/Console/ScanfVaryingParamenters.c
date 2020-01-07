#include <stdio.h>

int main() {
	char arquivo[] = "1 2 3 4 5";
	int a, b, c, d, e;
	sscanf (arquivo, "%d %d %d %d %d", &a, &b, &c, &d, &e);
	printf ("%d - %d - %d - %d - %d", a, b, c, d, e);
}

//https://pt.stackoverflow.com/q/126395/101
