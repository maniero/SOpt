#include <stdio.h>
#include <stdlib.h>

char *nome(char text[]) {    
    int n3 = 0;
    int n2 = 0;
    char *n = NULL;
    while((n2 = getchar()) != '\0' && n2 != EOF) {
        n3++;
        n = realloc(n, n3);
        if (n == NULL) {
            puts("Erro ao realocar!");
            exit(0);
        }
        *(n + (n3 - 1)) = n2;   
    }
    *(n + n3) = '\0';  
    return n;
}   

int main(void) {  
    char *name = nome("Nome:");
    char *iterador = name;
    while(*iterador != '\0') printf("%c", *iterador++);
    free(name);
}

//https://pt.stackoverflow.com/q/213845/101
