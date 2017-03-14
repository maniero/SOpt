#include <stdio.h>
#include <stdlib.h>

#define TAM_PILHA 2
#define NUM_ENTRA 5

void empilha(int *pilha, int *topo, int valor) {
   	printf("%d na posição %d ", valor, *topo);
	if (*topo < TAM_PILHA) {
	    pilha[*topo] = valor;
	    (*topo)++;
	} else {
	    printf("Pilha Cheia\n");
	}
}

int desempilha(int *pilha, int *topo) {
	if (*topo > 0) {
	    (*topo)--;
	    return pilha[*topo];
	} else {
	    printf("Pilha Vazia\n");
	    return -1;
	}
}

int main() {
	int pilha_par[TAM_PILHA] = { 0 }, pilha_impar[TAM_PILHA] = { 0 }, topo_par = 0, topo_impar = 0;
	for (int i = 0; i < NUM_ENTRA; i++) {
		int num_do_usuario = 0;
	    printf("\nEntre com um numero: ");
	    scanf("%d", &num_do_usuario);
	    if (num_do_usuario % 2 == 0) {
	    	printf("Vai entrar na pilha   par: ");
	        empilha(pilha_par, &topo_par, num_do_usuario);
	    } else {
	    	printf("Vai entrar na pilha impar: ");
	        empilha(pilha_impar, &topo_impar, num_do_usuario);
	    }
	}
	printf("\n\nNumeros pares sao: ");
	while (topo_par > 0) {
	    printf("%d ", desempilha(pilha_par, &topo_par));
	}
	printf("\n\nNumeros impares sao: ");
	while (topo_impar > 0) {
	    printf("%d ", desempilha(pilha_impar, &topo_impar));
	}
}

//http://pt.stackoverflow.com/q/189885/101
