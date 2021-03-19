#include <stdio.h>

int main() {
	int b = 5;
	int *a = &b;
	printf("%p\n", a);
	printf("%d\n", *a);
	printf("%d", b);
}

//https://pt.stackoverflow.com/q/496505/101
