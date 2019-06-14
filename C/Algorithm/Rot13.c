#include <stdio.h>

int main() {
    char palavra[255];
    printf("Digite a palavra que deseja criptografar: ");
    scanf(" %s", palavra);
    for (int i = 0; palavra[i] != '\0'; i++) {
        if (palavra[i] >= 'a' && palavra[i] < 'n') palavra[i] += 13;
        else if (palavra[i] >= 'n' && palavra[i] <= 'z') palavra[i] -= 13;
    }   
    printf ("\n%s\n", palavra);
}

//https://pt.stackoverflow.com/q/391324/101
