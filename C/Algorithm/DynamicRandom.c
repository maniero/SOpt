#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(void) {
    srand((unsigned)time(NULL));
	while (1) printf("%d\n", rand() % 100);
}

//https://pt.stackoverflow.com/q/128572/101
