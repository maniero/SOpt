#include <stdio.h>
#include <string.h>

int main(){
	char mensagem[200];
    printf("Digite a mensagem: ");
    fgets(mensagem, 200, stdin);
    mensagem[strcspn(mensagem, "\n")] = 0;
	int tamanho = strlen(mensagem);
	char vetor_binario[tamanho * 8 + 1];
	vetor_binario[tamanho * 8 + 1] = '\0';
    for (int i = 0; i < tamanho; i++) {
    	for (int j = 7; j >= 0; j--) {
            vetor_binario[i * 8 + (7 - j)] = ((mensagem[i] >> j) & 1) + '0';
        }
    }
    printf("%s", vetor_binario);
}

//https://pt.stackoverflow.com/q/216284/101
