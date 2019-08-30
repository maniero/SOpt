#include <stdlib.h>
#include <stdio.h>
#define BUFF_SIZE 1024

int main(void) {
    char buffer[BUFF_SIZE];
    while (fgets(buffer, BUFF_SIZE, stdin) != NULL) {
        printf("%s", buffer);
    }
}

//https://pt.stackoverflow.com/q/57102/101
