#include <stdio.h>
#include <stdlib.h>

int main() {
   char *texto; //declara a variável da forma como você sugeriu
   texto = malloc(31); //reserva o espaço em memória para 30 caracteres
   scanf("%s30", texto); //Lê caracteres pelo teclado e guarda os primeiros 30 em texto
   printf("%s", texto); //imprime o que foi entrado.
   free(texto); //libera a memória alocada
}

//https://pt.stackoverflow.com/q/37270/101
