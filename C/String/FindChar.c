#include <stdio.h>

int main() {
    char str[20];
    fgets(str, 18, stdin);
    for (int i = 0; str[i]; i++) {
        if (str[i] == 'c') printf("Achei");
        printf("[%c]", str[i]);
    }
}

//https://pt.stackoverflow.com/q/433537/101
