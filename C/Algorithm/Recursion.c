#include <stdio.h>
#include <stdlib.h>
#define BUF 2

void *overflow(int payload) {
    if (--payload) {
    	int *stack = malloc(payload * sizeof(int));
    	overflow(payload);
    }
}

int main(void) {
    overflow(BUF);
}

//https://pt.stackoverflow.com/q/236729/101
