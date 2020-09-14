#include <stdio.h>

void func1(int x) { //o valor do argumento é copiado para x
   printf("endereço de x: %p\n", (void *)&x); //peguei o endereço de x
   x = 9 * x; //mudou o parâmetro e logo em seguida é descartado
   printf("endereço de x: %p\n", (void *)&x); //peguei o endereço de x
}

void func2(int v[]) { //o valor do argumento é copiado para x, no caso é o valor do poneiro
   printf("endereço de v: %p\n", (void *)v); //v já é um endereço
   v[0] = 9 * v[0]; //o valor apontado para o primeiro elemento no objeto é mudado
   printf("endereço de v: %p\n", (void *)v); //v já é um endereço
}

int main () {
   int x = 111, v[2]; //x tem um valor direto na variável x, v tem um ponteiro para outro objeto
   func1(x); //111 é passado para a função, só isso, nada a ver com x
   printf("endereço de x: %p\n", (void *)&x); //peguei o endereço de x
   printf("x: %d\n", x); //x aqui continua sem ser alterado
   printf("endereço de x: %p\n", (void *)&x); //peguei o endereço de x
   printf("endereço de v: %p\n", (void *)v); //v já é um endereço
   v[0] = 111; //colocou um valor lá no objeto criado para ser o array
   printf("endereço de v: %p\n", (void *)v); //v já é um endereço
   func2(v); //o endereço da memória onde foi colocado o objeto array é passado para a função
   printf("endereço de v: %p\n", (void *)v); //v já é um endereço
   printf("v[0]: %d\n", v[0]); //acessando um dos elementos ele foi alterado
}

//https://pt.stackoverflow.com/q/472085/101
