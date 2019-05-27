#include <stdio.h>

int parOuImpar(int valor, int *quantidade) {
    if (valor % 2 == 0) {
        (*quantidade)++;
        return 1;
    } else return 0;
}

int main(){
   int num;
   scanf("%d", &num);
   int quantidade = 0;
   if (parOuImpar(num, &quantidade)) printf("O dado é par e isto ocorreu %d vezes", quantidade);
   else  printf("O dado é impar");
}

//https://pt.stackoverflow.com/q/387048/101
