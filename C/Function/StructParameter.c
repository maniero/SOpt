#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

typedef struct {
    char nome[50];
    int conta;
    int saldo;
} Cliente;

void cadastro_cliente(Cliente *cliente) {
    printf("\nInsira o nome completo do titular da conta: ");
    scanf("%49s", cliente->nome);
    printf("\nInsira o número da conta: ");
    scanf("%d", &cliente->conta);
    printf("\nInsira o saldo da conta: ");
    scanf("%d", &cliente->saldo);
}

int main() {
    setlocale(LC_ALL,"");
    Cliente clientes[1000] = {{ .nome = "", .conta = 0, .saldo = 0 }};
    for (int i = 0; i < 2; i++) cadastro_cliente(&clientes[i]);
    for (int i = 0; i < 2; i++) printf("\n%s - %d", clientes[i].nome, clientes[i].conta);
}

//https://pt.stackoverflow.com/q/257797/101
