#include <stdio.h>

int main(void) {
    char caractere, *caractere_ptr = &caractere;
    printf("Caractere: foi alocado %zu byte\n", sizeof(caractere));
    printf("Endereço: %p", caractere_ptr);
}

//http://pt.stackoverflow.com/q/179344/101
