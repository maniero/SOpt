#include <stdio.h>

int main() {
    char frase[200];
    printf("String: ");
    scanf("%200s", frase);
    for (char *i = frase; *i != '\0'; i++) {
        *i += *i < 'A' || *i > 'Z' ? 0 :
                    *i > 'W' ? -23 : 3;
    }
    printf("String: %s", frase);
}

//https://pt.stackoverflow.com/q/213908/101
