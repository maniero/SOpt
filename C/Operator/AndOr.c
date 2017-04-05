#include <stdio.h>

int main(void) {
    int y = 0;
    printf("Digite seu ano de nascimento (quatro digitos)\n");
    scanf("%d", &y);
    if (y > 9999 || y < 1000) { 
    	printf("Ano inválido");
    } else {
        int b = y % 100;
        int a = y / 100;
        int c = a + b;
        c %= 5;
        switch (c) {
            case 0: printf("Tímido\n"); break;
            case 1: printf("Sonhador\n"); break;
            case 2: printf("Paquerador\n"); break;
            case 3: printf("Atraente\n"); break;
            case 4: printf("Irresistível\n"); break;
        }
    }
}

//http://pt.stackoverflow.com/q/195129/101
