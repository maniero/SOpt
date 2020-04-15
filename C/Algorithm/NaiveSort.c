#include <stdio.h>

void swap(int *e1, int *e2) {
	int tmp = *e1;
	*e1 = *e2;
	*e2 = tmp;
}

void imprime(int array[], int size) {
    for (int j = 0; j < size; j++) printf("%d, ",array[j]);
     printf("\n");
}
	
int main(void) {
	int array[10] = { 2, 6, 4, 8, 10, 12, 89, 68, 45, 37 };
	int size = 10;
	for (int pass = 0; pass < size - 1; pass++) {
	    for (int j = 0; j < size - 1; j++) {
	        if (array[j] > array[j + 1]) swap(&array[j], &array[j + 1]);
	        imprime(array, size);
	     }
	     printf("--- Nova iteração ---\n");
	 }
}

//http://pt.stackoverflow.com/q/178136/101
