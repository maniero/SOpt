#include <stdio.h>

int main() {
    float raiz = 3.1415;
    float *aponta_para_raiz = &raiz;
    *aponta_para_raiz = 3.141592;
    printf("RAIZ = %f\n", raiz);
    printf("ENDEREÇO DA RAIZ MODIFICADA = %p", (void *)aponta_para_raiz);
}

//https://pt.stackoverflow.com/q/323674/101
