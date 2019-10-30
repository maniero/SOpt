#include <stdio.h>
#include <stdlib.h>

int main(void) {
	int * val = malloc(sizeof(int));
	*val = 0;
	*val += 1;
	printf("%d\n", *val);
	(*val)++;
	printf("%d\n", *val);
}

//https://pt.stackoverflow.com/q/99732/101
