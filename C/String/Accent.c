#include <stdio.h>
#include <locale.h>

int main(void) {
    int positivo = 32767;
    int negativo = -32768;
    setlocale(LC_ALL,"Portuguese");
    printf("%d +1 é %d\n", positivo, positivo + 1);
    printf("%d -1 é %d\n", negativo, negativo - 1); 
}

//https://pt.stackoverflow.com/q/169860/101
