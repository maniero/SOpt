#include <stdio.h>
#include <locale.h>

int main() {
    setlocale(LC_ALL, "Portuguese");
    char nome[31];
    char sexo;
    printf("Digite o seu nome: ");
    scanf("%30s", nome);
    printf("Digite o seu sexo M (Masculino) ou F (Feminino): ");
    scanf("%c", &sexo);
    if (sexo == 'f' ||  sexo == 'F') printf("\nOlá %s o seu sexo é feminino.", nome);
    else if (sexo == 'm' || sexo == 'M') printf("\nOlá %s o seu sexo é masculino.", nome);
    else printf("Sexo inválido");
}

//https://pt.stackoverflow.com/q/332649/101
