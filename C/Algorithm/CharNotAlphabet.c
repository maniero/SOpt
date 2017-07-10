#include <stdio.h>

int main(void) {
	char nome[30];
	scanf("%s", nome);
	int i;
	for (i = 0; nome[i] != '\0'; i++) { //sem strlen que seria péssimo
	    if (nome[i] < 'a' || nome[i] > 'z') { //lógica mais adequada
	        break; //encerra o laço, não tem porque continuar, achou algo que não muda mais
	    }
	}
	if (nome[i] != '\0') printf("Tem caracteres inválidos"); //se não chegou ao fim
}

//https://pt.stackoverflow.com/q/219389/101
