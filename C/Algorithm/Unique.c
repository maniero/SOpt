#include <stdio.h>
#include <stdlib.h>

int main() {
    int N, repetidos = 0;
    printf ("Entre com N: ");
    scanf ("%d", &N);
    int *v1 = malloc(N * sizeof (int));
 	int *aux = malloc(N * sizeof (int));
	int *flag = malloc(N * sizeof (int));
	int cont = 0;
    for (int i = 0; i < N; i++) {
	    scanf ("%d", &v1[i]);
		int achou = 0;
        for (int j = 0; j < cont; j++) {
            if (v1[i] == aux[j]) {
                flag[j] = 1;
                achou = 1;
                break;
            }
        }
        if (!achou) {
        	aux[cont] = v1[i];
        	flag[cont++] = 0;
        }
    }
    for (int i = 0; i < cont; i++) repetidos += flag[i];
    if (repetidos > 0) printf ("\n%d repetidos", repetidos);
}

//https://pt.stackoverflow.com/q/164021/101
