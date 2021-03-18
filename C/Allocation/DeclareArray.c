#include <stdlib.h>
#include <stdio.h>

void string_alunos(char *strings[], int num) {
    printf("\n::: PALAVRAS :::\n");
    for (int i = 0; i < num; i++) printf("%s\n", strings[i]);
}

int main() {
    int num;
    printf("Quantas strings voce deseja armazenar? ");
    scanf("%d", &num);
    char *strings[num];
    printf("\n");
    printf("Digite as palavras:\n");
    for (int i = 0; i < num; i++) {
        strings[i] = malloc(31);
        if (strings[i] != NULL) scanf("%30s[^\n]", strings[i]);
        else {
            printf("*** Não foi possível alocar memoria! ***");
            exit(1);
        }
    }
    string_alunos(strings, num);
    for (int i = 0; i < num; i++) free(strings[i]);
}

//https://pt.stackoverflow.com/q/498828/101
