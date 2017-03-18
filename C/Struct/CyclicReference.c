#include <stdio.h>

struct animal;

 typedef struct jogador {
    char nome[50];
    struct animal* animal;
 } TJogador;

typedef struct animal {
    char nome[50];  
    TJogador* jogador;
} TAnimal;

int main(void) {
	TJogador jogador = { .nome = "abc" };
	TAnimal animal = { .nome = "hipopo", .jogador = &jogador };
	jogador.animal = &animal;
}

//http://pt.stackoverflow.com/q/190991/101
