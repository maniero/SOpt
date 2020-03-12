#include <stdio.h>
#define MAX 6

int main(void) {
	int vet1[MAX];
	int vet2[MAX / 2];
	for (int i = 0; i < MAX; i++) scanf("%d", &vet1[i]);
	for (int i = 0; i < MAX / 2; i++) vet2[i] = vet1[i * 2] + vet1[i * 2 + 1];
	for (int i = 0; i < MAX / 2; i++) printf("%d\n", vet2[i]);
}

//https://pt.stackoverflow.com/q/157593/101
