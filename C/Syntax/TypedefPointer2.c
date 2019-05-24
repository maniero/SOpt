#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Estado CelEstado;

typedef struct estado {
    char nome[30];
    int populacao;
    int beneficiarios;
    int qtdCidades;
    float idh;
    CelEstado *proxEstado;
} Estado;

int main() {
    Estado newEstado; //instância da _struct_ celEstado
    strcpy(newEstado.nome, "Bahia"); //inserindo o nome do estado
    Estado *aux = malloc(sizeof(Estado));//alocando a memória pra uma célula estado
    strcpy(aux->nome, "Amazon");//o erro está aqui
    printf("%c", newEstado.nome[0]);//imprimindo o primeiro caractere
    printf("%c", aux->nome[0]);
}

//https://pt.stackoverflow.com/q/385036/101
