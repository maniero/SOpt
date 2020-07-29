#include <stdio.h>

int Comparacao(int x, int y)  {
    return x < y ? -1 : x != y;
}

int main(){
    int a, b;
    puts("Digite um valor para a: ");
    scanf("%d", &a);
    puts("Digite um valor para b: ");
    scanf("%d", &b);
    printf("%d", Comparacao(a, b));
}

//https://pt.stackoverflow.com/q/464605/101
