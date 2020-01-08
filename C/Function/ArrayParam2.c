#include<stdio.h>
#include<stdlib.h>
void func(int *ptr, int x) {
    for (int i = 0; i < x; i++) {
        printf("Digite o valor %d do vetor\n", i + 1);
        scanf("%d", &ptr[i]);
    }
}
int main () {
	int x;
	printf("Digite o numero de elementos que deseja\n");
	scanf("%i", &x);
	int *ptr = malloc(x * sizeof(int));
	func(ptr, x);
    for (int i = 0; i < x; i++) {
        printf ("%d\n", ptr[i]);
    }   
    free(ptr);
}

//https://pt.stackoverflow.com/q/126755/101
