#include <stdlib.h>
#include <stdio.h>

int main(void) {
    char *texto = malloc(10);
    if (texto == NULL) {
        printf("Houve um erro de alocação de memória");
        exit(EXIT_FAILURE);
    }
    int x;
    if (scanf("%d", &x) != 1) {
        printf("Houve um erro de leitura do dado");
        free(texto);
        exit(EXIT_FAILURE);
    }
    printf("%d", x);
    free(texto);
    return EXIT_SUCCESS;
}

//http://pt.stackoverflow.com/q/189633/101
