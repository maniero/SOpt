#include <stdio.h>
#include <stdlib.h>
#include <string.h>

//tirei os comentários porque eles davam indicações erradas mesmo
//o erro de runtime é provocado propositalmente pelo código através da função exit
void vazio(void) {
    char *str = malloc(1);
    char c;
    int i = 0;
    printf("Informe a string: ");
    do {
        c = getc(stdin);
        if (c != '\n') {
            str = realloc(str, i + 1);
            str[i++] = c;
        }
    } while (c != '\n');
    str[i] = '\0';
    if(strlen(str) == 0 || strcmp(str, "0") == 0) {
        printf("\7\a\nErro!\n");
        exit(EXIT_FAILURE);
    }
    printf("\nString: %s", str);
    free(str);
}

int main(void) {
	vazio();
}

//https://pt.stackoverflow.com/q/48119/101
