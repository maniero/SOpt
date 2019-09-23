#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
    int ano;
    int mes;
    int dia;
} Data;
typedef struct {
    char nome[20];
    char cpf[12];
    Data data_nasc;
} Pessoa;
void func1(Pessoa *pessoa) {
    strcpy(pessoa->nome, "Bigown");
    strcpy(pessoa->cpf, "040502016");
    pessoa->data_nasc.ano = 1990;
    pessoa->data_nasc.mes = 5;
    pessoa->data_nasc.dia = 15;
}
int main() {
	Pessoa *pessoa = malloc(sizeof(Pessoa));
    func1(pessoa);
    printf("Data: %d/%d/%d\nPessoa: %s\nCPF: %s ", pessoa->data_nasc.dia, pessoa->data_nasc.mes, pessoa->data_nasc.ano, pessoa->nome, pessoa->cpf);
}

//https://pt.stackoverflow.com/q/126814/101
