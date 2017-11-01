#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void proc(char msg[]) {
    msg = realloc(msg, 11);
    strcpy(msg, "xxxxxxxxxx");
    printf("\nin proc ======\n%s\n", msg);
}

int main() {
    char *msg = malloc(6);
    strcpy(msg, "12345");
    printf("Before proc\n%s", msg);
    proc(msg);
    printf("After proc\n%s\nFIM", msg);
}

//https://pt.stackoverflow.com/q/251727/101
