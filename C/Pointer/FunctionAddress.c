#include <stdio.h>

int f1() {}

int main(void) {
	printf("%p, %p, %p, %p", main, printf, scanf, f1);
}

//https://pt.stackoverflow.com/q/402794/101
