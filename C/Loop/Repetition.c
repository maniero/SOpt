#include<stdio.h>
#include<math.h>
#include<locale.h>

int main () {
    setlocale(LC_ALL, "portuguese");
    int n;
    printf("\n Digite o tamanho da sequência: "); 
    scanf("%d", &n);
    int somaPositivo = 0;
    int somaNegativo = 0;
    for (int i = 0; i < n; i++) {
        printf("\n Digite um número da sequência: "); 
        int num;
        scanf("%d", &num);
        if (num > 0) somaPositivo += num;  
        else somaNegativo += num;
    } 
    printf("\n A soma dos números positivos da sequência é: %d\n", somaPositivo);
    printf("\n A soma dos números negativos da sequência é: %d\n", somaNegativo);
}

//https://pt.stackoverflow.com/q/243465/101
