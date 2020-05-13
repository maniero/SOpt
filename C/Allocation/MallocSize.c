#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[]) {
	int n = 5;
    int *p = malloc(n * sizeof(int));
    printf("%p = %d\n", (void *)p, n);
}

//https://pt.stackoverflow.com/q/198478/101
