#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
    char *str = "   teste";
    int j = 0;
    while (str[j] == ' ') j++;
    int size = strlen(str) - j + 1;
    char *result = malloc(size);
    memcpy(result, str + j,  size);
    printf("%s", result);
}

//https://pt.stackoverflow.com/q/126134/101
