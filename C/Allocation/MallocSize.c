#include <stdio.h>
#include <stdlib.h>

int main(int argc, char const *argv[]) {
	int n = 5;
    int *p = malloc( n * sizeof(int));
    printf("%d\n", n);
}

//https://pt.stackoverflow.com/q/198478/101
