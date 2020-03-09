#include <stdio.h>

int main(){
	int vec[] = {52, 13, 12, 14};
	printf("Endereço de vetor %p\n", (void*)vec);
	printf("vec[0] = %p, vec[1] = %p, vec[2] = %p, vec[3] = %p\n", (void*)&vec[0], (void*)&vec[1], (void*)&vec[2], (void*)&vec[3]);
}

//https://pt.stackoverflow.com/q/155122/101
