#include<stdio.h>
#include<string.h>

int main() {
    char valor[1000];
    long long int valor_i;
    int position = 0, count = 0;
    scanf("%lld", &valor_i);
    while (valor_i > 0) {
        int bit = valor_i % 2;
        valor[position++] = '0' + bit;
        count += bit;
        valor_i /= 2;
    }
    valor[position] = '\0';
    size_t size = strlen(valor);
    for (int count = 0; count <= size / 2 - 1; count++) {
        char tmp = valor[count];
        valor[count] = valor[size - count - 1];
        valor[size - count - 1] = tmp;
    }
    printf("%s - quantidade de '1' => %d\n", valor, count);
}

//https://pt.stackoverflow.com/q/152377/101
