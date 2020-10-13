#include <stdbool.h>
#include <stdio.h>
#include <ctype.h>

bool minusculo(const char *s) {
    for (int i = 0; s[i] != 0; i++) if (isupper(s[i])) return false;
    return true;
}

int main(){
    char str[] = "1 exercicio pratico ";
    if (minusculo(str)) printf("\"%s\" tem todos os caracteres minusculos\n", str);
    else printf("\"%s\" NAO tem todos os caracteres minusculos\n", str);
}

//https://pt.stackoverflow.com/q/476026/101
