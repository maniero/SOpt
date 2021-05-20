#include <stdio.h>

int main() {
	char vet1[20] = "Bom ";
	char vet2[20] = "dia";
	int i;
	for (i = 0; vet1[i] != '\0'; i++);
	for (int j = 0; vet2[j] != '\0'; j++) vet1[i++] = vet2[j];
	printf("%s", vet1);
}

//https://pt.stackoverflow.com/q/509832/101
