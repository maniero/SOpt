#include <stdio.h>
#include <string.h>

int main() {
	char var[50] = " Write Once Run Everywere ";
	int cont = 0;
	for (int i = 0; i < 50; i++) {
	    if (var[i] == ' ') {
	        cont++;
	    }
	}
	printf("Existem %d espaços em branco", cont);   
}

//http://pt.stackoverflow.com/q/185005/101
