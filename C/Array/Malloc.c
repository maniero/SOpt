#include <stdio.h>
#include<stdlib.h>

int main() {
    int M;
    printf("Entre com M: ");
    scanf("%d", &M);
    int *v = malloc(M * sizeof(int));
    for (int i = 0; i < M; ++i) {
    	v[i] = i + 1;                
        printf ("%d ", v[i]);
	}
}

//https://pt.stackoverflow.com/q/163942/101
