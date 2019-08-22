#include <stdio.h>
#include <string.h>

int main(void) {
   	int vetor[10] = {0};
   	for (int i = 0; i < 10; i++) printf("%d", vetor[i]);
  	for (int i = 0; i < 10; i++) vetor[i] = 1;
   	for (int i = 0; i < 10; i++) printf("%d", vetor[i]);
	memset(vetor, 0, sizeof(vetor));
   	for (int i = 0; i < 10; i++) printf("%d", vetor[i]);
}

//https://pt.stackoverflow.com/q/55628/101
