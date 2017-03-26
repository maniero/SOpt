#include <stdio.h>
#include <string.h>
#define N 20

int main() {
    char palavra[N];
    printf("Insira uma palavra: ");
    scanf("%s", palavra);
    int tamanho = strlen(palavra);
    for (int i = 0; i < tamanho / 2; i++) { //só precisa ir até o meio
        if (palavra[i] != palavra[tamanho - i - 1]) {
            printf("\nA palavra inserida nao eh um palindromo.");
            return 0;
        }
    }
    printf("\nA palavra inserida eh um palindromo.");
}

//http://pt.stackoverflow.com/q/192842/101
