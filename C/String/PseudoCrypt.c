#include <stdio.h>

int main(void) {
    char texto[] = "GostoDeVoce";
    int i = 0; //size_t é mais correto ,mas deixei int para facilitar
    while (texto[i] != '\0') printf("%c", texto[i++] + 1);
}

//https://www.tabnews.com.br/maniero/2d80a58b-bd6e-4c11-8dbd-54e72734b818
