#include <stdio.h>

void main() {
    FILE *file = fopen("/home/Documentos/teste.odt", "w");
    fprintf(file, "alo\n"); 
    fclose(file);
}

//https://pt.stackoverflow.com/a/40841/101
