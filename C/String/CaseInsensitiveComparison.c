#include <stdio.h>
#include <string.h>
#include <strings.h>

int main(void) {
    char lugar[20]; //cria o array de caracteres para armazenar o texto
    printf("Digite o nome de um lugar: ");
    scanf("%20s", lugar); //não precisa da referência porque o array já é uma, precisa %s
    if (strcasecmp(lugar, "Escola") == 0) { //use a função para comparar todos os caracteres
        printf("\nEstudar");
    }
}

//http://pt.stackoverflow.com/q/193348/101
