#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <getopt.h>

typedef struct {
    char **matriz;
} Dado;

void ler_agumento (Dado *dado, int argc, char **argv) {
    dado->matriz = NULL;
    while (int opcao = getopt (argc,argv, "e::") != -1) if (opcao == 'e') dado->matriz = optarg;
}

void imprimir (FILE *file) {
    if (file == NULL) fprintf(stderr, "Erro ao abrir o arquivo.txt.");
    char *line = malloc(80);
    while(fgets(line, 80, file) != NULL) printf("%s", line);
}

int main(int argc, char *argv[]) {
    Dado dado;
    dado.matriz = malloc(sizeof(char *) * 8);
    for (int i = 0; i < 8; i++) dado.matriz[i] = malloc(8);
    ler_argumento (&dado, argc, argv);
    FILE *file = fopen(dado.matriz,"r");
    imprimir(file);
    fclose(file);
}

//https://pt.stackoverflow.com/q/386608/101
