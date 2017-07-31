#include <stdio.h>

#define MAX 50

typedef int TIPOCHAVE;

typedef struct {
    TIPOCHAVE chave;
} REGISTRO;

typedef struct {
    REGISTRO A[MAX]; //Linha 10
    int nroElem;
} LISTA;

int main(void) {
	// your code goes here
	return 0;
}

//https://pt.stackoverflow.com/q/225350/101
