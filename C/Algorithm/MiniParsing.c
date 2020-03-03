#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main() {
    char t[10];
    char r[10];
    fgets(t, 10, stdin);
    int c = 0;
    for (int i = 0; i < 10 && t[i] != 0; i++) {
        if (isdigit(t[i]) || t[i] == 'i' || t[i] == 'p' || t[i] == '+' || 
                t[i] == '-' || t[i] == '*' || t[i] == '/' || t[i] == '^') {
            r[c++] = t[i];
        }
    }
    r[c] = '\0';
    printf("%s", r);
}

//https://pt.stackoverflow.com/q/152112/101
