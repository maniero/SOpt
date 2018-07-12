#include <stdio.h>

int main() {
    char sex, nome[200];
    printf("Digite o seu nome: ");
    scanf(" %[^\n]s", nome);
    printf("\nDigite seu sexo f ou m:"); //pegar o sexo da pessoa
    scanf("%s", &sex);
    if (sex == 'm' || sex == 'M') printf("Bem vindo Senhor %s\n", nome);
    else if (sex == 'f' || sex == 'F') printf("Bem vinda Senhora %s\n", nome);
    else printf("\n ERRO! \n");
}

//https://pt.stackoverflow.com/q/313747/101
