#include <stdio.h>
#include <string.h>

typedef struct Animal {
    char nome[6]; //se precisa de 5 caracteres o tamanho tem que ser 6 para acomodar o terminador
    int idade;
} Cachorro;

int main() {
    Cachorro dog;
    dog.idade = 9;
    strcpy(dog.nome, "Salfr"); //esta é a forma correta pra copiar uma string para uma variável
    printf("'%s' '%d'", dog.nome, dog.idade);
}

//https://pt.stackoverflow.com/q/136628/101
