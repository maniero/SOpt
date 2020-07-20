#include <stdio.h>
#include <string.h>

char *local(void) {
    static char nomex[12] = "aaaaaaaaaa";
    char nome[12] = "programador";
    char *ponteiro = nome;
    printf("%s\n", nome);
    printf("%s\n", ponteiro);
    printf("%p\n", (void *)ponteiro);
    printf("%p\n", (void *)nome);
    printf("%p\n", (void *)nomex); 
    printf("%p\n", (void *)&ponteiro); 
    return ponteiro;
}

int main(void) {
    char *ponteiro = local();
    printf("%s\n", ponteiro);
    printf("%c\n", ponteiro[0]);
    printf("%p\n", (void *)ponteiro);
}

//https://pt.stackoverflow.com/q/297376/101
