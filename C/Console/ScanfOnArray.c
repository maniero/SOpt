#include <stdio.h>

int main(void) {
	int vetorA[10] = { 0 };
	int vetorB[10] = { 0 };
	for (int i = 0; i < 10; i++) {
		printf("Vetor A: \n");
		scanf("%d", &vetorA[i]);
	}
	for (int i = 0; i < 10; i++){
		printf("Vetor B: \n");
		scanf("%d", &vetorB[i]);
	}
}

//http://pt.stackoverflow.com/q/189939/101
