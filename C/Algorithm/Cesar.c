#include <stdio.h>
#include <string.h>
int main() {
	char texto[100];
	int i = 0, con = 0, tam;
	printf("texto\n");
	fgets(texto, 100, stdin);
	printf("constante\n");
	scanf("%d", &con);
	tam = strlen(texto);
	char cesar[tam];
	for(i = 0; i < tam; i++) {
	    if(texto[i] >= 'a' && texto[i] <= 'z')
	        cesar[i] = ((texto[i] - 97 + con) % 26 + 97);
	    else
	        cesar[i] = texto[i];
	
	    printf("%c", cesar[i]);
	}
}

//https://pt.stackoverflow.com/q/93098/101
