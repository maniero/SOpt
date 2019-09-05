#include <stdio.h>
#include <string.h>
#include <stdlib.h> // <=========== faltava este include
#define Nome "nome"
#define TAM_STRING 12

int main(void) { // <========== o retorno aqui precisa ser um int
    char * str = malloc(TAM_STRING); // <======= a declaração pode e deve ser mais simples
    if (str == NULL) printf("Não já espaço para alocar");
    else { 
        strcpy(str, Nome); // <======= acredito que queria usar esta função, não tinha o nome dela
        int tamanho = strlen(Nome);
        printf("Nome=[%s] tem [%d] caracters", str, tamanho);
        for (int i = 0; i < tamanho; i++) {
            printf("\nCaracter[%d] = [%c]\n", i , str[i]);
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') printf("Vogal");
        }
        free(str);
    }
}

//https://pt.stackoverflow.com/q/58741/101
