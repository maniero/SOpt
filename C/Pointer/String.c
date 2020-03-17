#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <string.h>

void limpa () {
    fflush(stdin); //isso não serve pra nada aqui
}

int main() {
	setlocale(LC_ALL,"Portuguese"); //nesse código isso é disponsável
    int inteiro = 1, *i;
    float flutua = 1.0;
    float* f;
    char texto[20] = "Hello";
    char t[3]; //deveria declarar e atribuir junto
    i = &inteiro; *i = 2; //isso não faz sentido
    f = &flutua; *f = 2.0; //idem
    limpa();
    strcpy(t, texto); strcpy(t, "Oi"); //para copiar uma string para outra tem que usar strcpy()
    printf("Os valores são %i, %.2f, %s.\n", *i, *f, t); //variável que já é ponteiro passa direto
}

//https://pt.stackoverflow.com/q/160692/101
