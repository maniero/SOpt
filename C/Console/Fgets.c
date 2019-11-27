#include <stdio.h>

int main() {
    char op = ' ';
    char letra = ' ';
    do {
        printf("\n0) Sair\
            \n1) Digite uma letra\
            \n2) Mostre a letra\
            \nOp: ");
        scanf(" %c", &op);
        switch (op) {
            case '0':
                break;
            case '1':
            	printf("\nLetra: ");
            	scanf(" %c", &letra);
            	break;
            case '2':
            	printf("\nLetra digitada: %c", letra);
            	break;
            default:
                printf("\nOpcao invalida.");
        }
    } while (op != '0');
    printf("fim");
}

//https://pt.stackoverflow.com/q/109966/101
