#include <stdio.h>
#include <stdlib.h>

void carrega(int *n) {
	FILE *f = fopen("arquivo.txt", "r");
	for (int i = 0; i < 3; i++) fscanf(f, "%d", &n[i]);
	fclose(f);
}

int main() {
	int *n = malloc(3 * sizeof(int));
	carrega(n);
	for (int i = 0; i < 3; i++) printf("%d\n", n[i]);
	free(n);
	system("pause");
}

//https://pt.stackoverflow.com/q/334864/101
