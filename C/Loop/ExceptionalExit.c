#include <stdio.h>

int main() {
	char elenco[20][30];
	int cont = 0;
	for (int i = 0; i < 20; i++, cont++) {
	    printf("\nindique um menbro do elenco ,se quiser sair escreva apenas a letra S");
	    scanf("%29s", &elenco[i][0]);
	    if  (elenco[i][0] == 'S' && elenco[i][1] == '\0') break;
	}
	for (int i = 0; i < cont; i++) printf("\nElenco: %s", elenco[i]);
}

//https://pt.stackoverflow.com/q/262834/101
