#include <stdio.h>
#include <limits.h>

int main() {
    int i = 0;
    while (i < INT_MAX) {
        char buffer[100] = "";
        sprintf(buffer, "pathping xxx.xxx.xxx.xxx > %d.txt\n", i++);
        printf(buffer);
    }
}

//https://pt.stackoverflow.com/q/170495/101
