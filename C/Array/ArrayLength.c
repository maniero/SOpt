#include <stdio.h>
int main() {
    char *palavra[] = {"casa", "carro"};
    for(int i = 0; i < sizeof(palavra) / sizeof(palavra[0]); i++) {
        printf("%s", palavra[i]);
    }
}

//http://pt.stackoverflow.com/q/178522/101
