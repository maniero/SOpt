#include <stdio.h>

int main() {
    char str[101];
    fgets(str, 100, stdin);
    for (int i = 0; str[i] && str[i] != '\n'; i++) printf("%c", str[i] + 1);
}

//https://pt.stackoverflow.com/q/478699/101
