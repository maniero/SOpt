#include <stdio.h>

int main(void) {
	int n[5] = { 0 };
	for (int i = 0; i < 5; i++) printf("%d\n", n[i]);
	for (int i = 0; i < 5; i++) n[i] = i + 1;
	for (int i = 0; i < 5; i++) printf("%d\n", n[i]);
}

//https://pt.stackoverflow.com/q/107506/101
