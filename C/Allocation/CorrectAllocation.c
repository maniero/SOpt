#include <stdio.h>
#include <stdlib.h>

void LerArray(int numElementos , float * elemArray) {
    for (int i = 0; i < numElementos; i++) {
  	    float num;
        printf("Digite um numero para seu array:  ");
        scanf("%f", &num);
        *(elemArray + i) = num;
        printf("\n\n");
    }
}

int main() {
  int numElementos;
  printf("Oi !!!  Quantos elementos vc quer armazenar: ");
  scanf("%d", &numElementos);
  system("clear");
  float * vetorNum;
  vetorNum = malloc(numElementos * sizeof(float));
  if (vetorNum == NULL) {
  	printf("Erro na alocação, talvez funcione um um número de elementos menor ");
  	return 1;
  }
  LerArray(numElementos, vetorNum);
  free(vetorNum);
}

//https://pt.stackoverflow.com/q/55328/101
