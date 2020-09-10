#include <stdio.h>
#include <time.h>

int main(void) {
	srand(time(NULL));
	for (int i = 0; i < 100; i++) printf("%i\n", 1001 + rand() % 4000);
}

//https://pt.stackoverflow.com/q/39215/101
