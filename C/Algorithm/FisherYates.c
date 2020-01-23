#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MIN 1
#define MAX 1000000
#define QTDE 10000  //precisa ser menor que MAX

void shuffle(int *array) {
	for (int i = MAX - MIN - 1; i > 0; i--) {
        int j = rand() % (i + 1);
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
    }
}

int main(void) {
    srand(time(NULL));
    int * numeros = malloc((MAX - MIN) * sizeof(int));
	if (!numeros) exit(EXIT_FAILURE);
	for (int i = 0; i < MAX - MIN; i++) numeros[i] = i + MIN;
	shuffle(numeros);
	for (int i = 0; i < QTDE; i++) printf("%d\n", numeros[i]);
}

//https://pt.stackoverflow.com/q/136206/101
