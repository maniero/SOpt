#include <stdio.h>

int main(void) {
    const char str[7] = "string";
    const char *str1 = str;
    if(str == str1) printf("Endereços de memória iguais");
}

//https://pt.stackoverflow.com/q/340098/101
