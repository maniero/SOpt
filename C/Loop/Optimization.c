#include <stdio.h>

int main () {
	int I, F;
	do {
		scanf("%d", &I);
		scanf("%d", &F);
	} while (I >= F);
	for (; I < F; I++, F--) {
		printf("%d %d ", I, F);
	}
	if (I == F) {
		printf("%d ", I);
	}
	printf("\nfim de programa\n");
}

//https://pt.stackoverflow.com/q/204611/101
