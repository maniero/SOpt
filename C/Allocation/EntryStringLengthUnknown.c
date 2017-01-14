#include <stdio.h>
#include <stdlib.h>

int main(void) {
    int size = 0;
    char *nome = malloc(2); //espaço extra para 1 caractere mais o terminador de string \0
    while (1) {
        if ((scanf("%c", &nome[size])) == 1) {
        	nome[size + 1] = '\0'; //colcoa o terminador
        	if (nome[size] == '\n') {
        		break;
        	}
        	nome = realloc(nome, ++size);
        	if (nome == NULL) {
	        	printf("Ocorreu ualgum problema");
	            break;
        	}
        } else {
        	printf("Ocorreu ualgum problema");
            break;
        }
    }
    printf("%s", nome);
    free(nome);
}

//http://pt.stackoverflow.com/a/177413/101
