#include <stdio.h>

int main(void){
    char *matriz[2][2];
    char string1[] = "Minha string";
    matriz[0][0] = string1;
    printf("%s", matriz[0][0]);
}

//https://pt.stackoverflow.com/q/234916/101
