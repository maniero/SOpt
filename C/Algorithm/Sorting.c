#include <stdio.h>

int main(void) {
	int a[10];
	for (int i = 0; i < 10; i++) {
	    printf("Entre com os numeros %d: ", i);
	    scanf("%d", &a[i]);
	}
    for (int i = 0; i < 10; i++) {
		for (int x = i + 1; x < 10; x++) {
			if (a[i] > a[x]) {
				int aux = a[i];
			    a[i] = a[x];
				a[x] = aux;
			}
		}
    }
	printf ("Lista dos elementos em ordem a seguir:\n");
	for (int i = 0; i < 10; i++) printf("%d\n", a[i]);
}

//https://pt.stackoverflow.com/q/359966/101
