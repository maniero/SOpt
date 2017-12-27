#include <stdio.h>
#include <string.h>

char *troca(char nome[100]) {
    for (int i = 0, j = strlen(nome) - 1; i < j; i++, j--) {
    	char temp = nome[i];
    	nome[i] = nome[j];
    	nome[j] = temp;
    }
    return nome;
}
  
int main(void) {
   char nome[100];
   printf("Informe o nome para ser invertida :");
   scanf("%[^\n]s", nome);
   printf("%s\n", troca(nome));
}

//https://pt.stackoverflow.com/q/265266/101
