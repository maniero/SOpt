#include <stdio.h>
#include <stdlib.h>

int main(){
    char *ponteiro = malloc(100);
    printf("String: ");
    scanf("%99s", ponteiro);
    free(ponteiro);
}

//https://pt.stackoverflow.com/q/45796/101
