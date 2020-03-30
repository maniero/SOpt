#include <cstdio>

int main(void) {
    int num;
    printf("Digite um numero inteiro: ");
    scanf("%d", &num);
    if (num > 0) printf("O numero e positivo");
    else if (num < 0) printf("O numero e negativo");
    else if (num == 0) printf("O numero e zero");
}

//https://pt.stackoverflow.com/q/442084/101
