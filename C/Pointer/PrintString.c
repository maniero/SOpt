#include <stdio.h>

void imprime(char *v, int n) {
    for (char *c = v; c < v + n; c++) printf ("%c", *c);
}

int main() {
    char texto[] = "teste de texto";
    imprime(texto, 5);
}

//https://pt.stackoverflow.com/q/155557/101
