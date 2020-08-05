#include <stdio.h>
#include <stdlib.h>

typedef struct {
    int codigo;
    float saldo;
} Conta;

int ler_dados() {
    int cod;
    printf("Digite o codigo:");
    scanf("%d", &cod);
    return cod;
}

int inserir(Conta *contas, int tamanho) {
    int codigo = ler_dados();
    if (codigo == 0) return tamanho;
    contas = realloc(contas, sizeof(int) * (tamanho + 1));
    contas[tamanho].codigo = codigo;
    contas[tamanho].saldo = 0;
    return ++tamanho;
}

int main (void) {
    Conta *contas = malloc(sizeof(int));
    int tamanho = 0;
    while (1) {
        int retorno = inserir(contas, tamanho);
        if (retorno == tamanho) break;
        tamanho = retorno;
    }
    printf("Vetor\n");
    for (int i = 0; i < tamanho; i++) printf("%d\n", contas[i].codigo);
    free(contas);
}

//https://pt.stackoverflow.com/q/326124/101
