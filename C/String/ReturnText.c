#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void teste(char texto[10]) {
    strcpy(texto, "Ponteiro"); //isto não é seguro, mas sabemos que funciona neste caso
}

char *teste2() {
	char *texto = malloc(10);
    if (texto != NULL) strcpy(texto, "Ponteiro"); //neste caso dá para eliminar isto, deixai porque o normal é fazer assim
    return texto;
}

int main () {
	char texto[10];
	teste(texto);
    printf("\nRESULTADO: %s\n", texto);
    //segunda forma não recomendada
    char *texto2 = teste2();
    if (texto2 != NULL) {
        printf("\nRESULTADO: %s\n", texto2);
        free(texto2); //tem que librar a memória que foi alocada por outra função
    }
}

//https://pt.stackoverflow.com/q/252163/101
