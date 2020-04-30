#include <stdio.h>
#include <errno.h>
#include <stdlib.h>
#include <string.h>
 
int main(void) {
	char *end;
    printf("\" 999999999999999999999999999999999999999999999\" em decimal --> %ld - ", strtol(" 999999999999999999999999999999999999999999999", &end, 10));
    printf("Erro: %s\n", strerror(errno));
    printf("\"1010\" em binário --> %ld\n", strtol("1010", NULL, 2)); //sem tratamento de erro
    printf("\"12\" em octal     --> %ld\n", strtol("12", NULL, 8));
    printf("\"A\"  em hex       --> %ld\n", strtol("A", NULL, 16));
    printf("\"junk\" em base 36 --> %ld\n", strtol("junk", NULL, 36));
    printf("\"012\" detecção    --> %ld\n", strtol("012", NULL, 0));
    printf("\"0xA\" detecção    --> %ld\n", strtol("0xA", NULL, 0));
    printf("\"junk\" detecção   -->  %ld - ", strtol("junk", &end, 0));
    printf("Erro: %s\n", strerror(errno));
}

//http://pt.stackoverflow.com/q/185345/101
