#include <stdio.h>

long binario(int num) {
	if (num == 0)
		return 0;
	return (num % 2) + 10 * binario(num / 2);
}

int main() {
	printf("%ld", binario(1025));
}

//http://pt.stackoverflow.com/q/184447/101
