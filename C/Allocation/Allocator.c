#include<stdio.h>
#include<stdlib.h>

typedef struct {
    char *name;
    char *phone;
    char *city;
    char *state;
} ficha_t;

void aloca(char **ptr, int tamanho) {
    *ptr = (char *)realloc(*ptr, tamanho + 1);
    if(ptr == NULL){
        puts("** Memória Insuficiente **");
        exit(0);
    }
}

char *preenche() {
    char *dados = NULL;
    int i = 0;
    do {
        aloca(&dados, i);
        dados[i++] = getchar();
    } while (dados[i - 1] != '\n');
    dados[i - 1] = '\0';
    return dados;
}

int main(int argc, const char *argv[]) {
    ficha_t ficha;
    ficha.name = preenche();
    printf("%s", ficha.name);
}

//https://pt.stackoverflow.com/q/52555/101
