#include <stdio.h>

int main() {
	int fib[100];
	int n;
	scanf("%d", &n);
	fib[0] = 0;
	fib[1] = 1;
	n--;
	for (int i = 2; i < n; i++) fib[i] = fib[i - 1] + fib[i - 2];
	for (int i = 0; i < n; i++) printf("%d ", fib[i]);
}

//https://pt.stackoverflow.com/q/244268/101
