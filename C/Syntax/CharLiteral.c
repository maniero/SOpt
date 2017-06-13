#include <stdio.h>
#include <stdlib.h>

int main() {
	int parar=1; // Condição para parar.
	int a=0, b=0, c=0; //Elevadores
	int count=0; //Numero de pessoas
	char elevador=' '; //Elevador
	do {
	    printf("Elevador: ");
	    scanf("%c", &elevador);
	    if (elevador == 'a') {
	        a++;
	        count++;
	    } else if (elevador == 'b') {
	        b++;
	        count++;
	    } else if (elevador == 'c') {
	       c++;
	       count++;
	    } else {
	        printf("inválido!");
	    }
        printf("\nContinuar respondendo? s=1 n=0");
        scanf("%d", &parar);
    } while (parar != 0);
}

//https://pt.stackoverflow.com/q/212422/101
