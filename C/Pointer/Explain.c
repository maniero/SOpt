#include <stdio.h>

int main() {
    int i = 5;
    int *p = &i;
    printf("%u\n", p);  //é o endereço de i
    printf("%d\n", *p);  //é o valor de i obtido pelo endereço que está em p
    printf("%d\n", (*p) + 2); //pega o valor de i e soma 2
    printf("%d\n", (&p));  //pega o endereço de p
    printf("%d\n", (*(&p))); //com o endereço de p pega o valor dele, que é o endereço de i
    printf("%d\n", *(*(&p))); //então pega o valor de i, isto é o mesmo que *p
    printf("%d\n", 3 * (*p)); //multiplica 3 pelo valor de i, é o mesmo que 3 * i
    printf("%d\n", *(*(&p)) + 4);  //soma 4 em i através de uma fórmula desnecessária
}

//https://pt.stackoverflow.com/q/247773/101
