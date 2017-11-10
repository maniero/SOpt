#include <stdlib.h>
#include <stdio.h>

int main() {
    char str[] = "\nUtilizador 1 --> Bom dia! Tudo bem contigo?\n\nUtilizador 2 --> Comigo tudo excelente. Que tens feito?\nUtilizador 1 --> De momento estou a trabalhar num projeto... E tu?\nUtilizador 2 --> Eu tenho estudado uma nova linguagem, Java. Bastante interessante. Devias experimentar.\nUtilizador 2 --> Talvez experimente quando tiver algum tempo livre!\n";
    char **matriz = malloc(sizeof(char *) * 255);
    int linha = 0;
    matriz[linha] = malloc(255);
    for (int caractere = 0, coluna = 0; str[caractere] != '\0'; caractere++, coluna++) {
        matriz[linha][coluna] = str[caractere];
        if (str[caractere] == '\n' || str[caractere] == '\0' || str[caractere] == '.' || str[caractere] == '!' || str[caractere] == '?') {
            if (str[caractere] == '.' && str[caractere + 1] == '.' && str[caractere + 2] == '.') {
            	matriz[linha][++coluna] = str[++caractere];
            	matriz[linha][++coluna] = str[++caractere];
            }
            if (str[caractere] == '\n' && coluna == 0) {
            	coluna = -1;
            	continue;
            }
            if (str[caractere] == '\n' || str[caractere] == '\0') {
            	matriz[linha][coluna] = '\0';
            } else {
            	matriz[linha][++coluna] = '\0';
            	caractere++;
            }
            matriz[linha] = realloc(matriz[linha], coluna + 1);
            matriz[++linha] = malloc(255);
            coluna = -1;
        }
    }
    matriz = realloc(matriz, sizeof(char *) * linha);
    for (int i = 0; i < linha; i++) {
        printf("%s\n", matriz[i]);
    }
}

//https://pt.stackoverflow.com/q/254401/101
