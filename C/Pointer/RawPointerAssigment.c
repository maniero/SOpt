#include <stdio.h>

int main(void) {
    int inteiro = 4;
    int *inteiro_ptr = 4;
    printf("Valor da variariavel 'inteiro': %d\n", inteiro);
    printf("Endereco da variariavel 'inteiro': %d\n", &inteiro);
    printf("Valor armazenado no ponteiro 'inteiro_ptr': %d\n", inteiro_ptr);
    printf("Endereco armazenado no ponteiro 'inteiro_ptr': %d\n\n", &inteiro_ptr);
    printf("Apos o uso dos ponteiros, vamos aponta-los para NULL\n\n");
    inteiro = NULL;
    inteiro_ptr = NULL;
    printf("Endereco armazenado no ponteiro 'inteiro': %d\n", inteiro);
    printf("Endereco armazenado no ponteiro 'inteiro_ptr': %d\n", inteiro_ptr);
}

//https://pt.stackoverflow.com/q/136535/101
