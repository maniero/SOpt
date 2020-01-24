#include <stdio.h>
#include <stdlib.h>
int main(void) {
    int inteiro = 4;
    int *inteiro_ptr = malloc(sizeof(int));
    *inteiro_ptr = 4;
    printf("Valor da variariavel 'inteiro': %d\n", inteiro);
    printf("Endereco da variariavel 'inteiro': %p\n", (void *)&inteiro);
    printf("Valor armazenado no ponteiro 'inteiro_ptr': %d\n", *inteiro_ptr);
    printf("Endereco armazenado no ponteiro 'inteiro_ptr': %p\n\n", (void *)inteiro_ptr);
    printf("Apos o uso dos ponteiros, vamos aponta-los para NULL\n\n");
    inteiro = 0;
    inteiro_ptr = NULL;
    printf("Endereco armazenado no ponteiro 'inteiro': %d\n", inteiro);
    printf("Endereco armazenado no ponteiro 'inteiro_ptr': %p\n", (void *)inteiro_ptr);
}

//https://pt.stackoverflow.com/q/136535/101
