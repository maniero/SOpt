#include <stdio.h>
#define SUB_UNSAFE(x, y) x * y
#define SUB(x, y) ((x) * (y))

int main(void) {
	printf("%d\n", SUB_UNSAFE(4 - 4, 2));
	printf("%d\n", SUB(4 - 4, 2));
}

//http://pt.stackoverflow.com/q/192041/101
