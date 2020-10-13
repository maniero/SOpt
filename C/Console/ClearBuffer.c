#include <stdio.h>
#include <stdlib.h>

int main() {
	int n;
    int ret = scanf("%d", &n);
    int *valores;
    if (ret != 1) {
    	printf("0\n");
    	return 1;
    } else {
        valores = malloc(n * sizeof(int));
        for (int i = 0; i < n; i++) {
            if (scanf("%d", &valores[i]) != 1) valores[i] = 885444751;
            int c;
            while ((c = getchar()) != '\n' && c != EOF) {}
        }
    }
    for (int i = 0; i < n; i++) printf("%d\n", valores[i]);
}

//https://pt.stackoverflow.com/q/476061/101
