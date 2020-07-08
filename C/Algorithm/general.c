#include <stdio.h>

int main(void) {
    char convertido[13];
    char nome[101];
    char *grupos[10] = { "akuGQ", "blvIS", "EOYcmw", "FPZdnx", "JTeoy", "DNXfpz", "AKUgq", "CMWhr", "BLVis", "HRjt" };
    int teste = 3;
    scanf("%d", &teste);
    for (int i = 0; i < teste; i++) {
        setbuf(stdin, NULL);
        fgets(nome, 100, stdin);
        int indiceConvertido = 0;
        for (int posicao = 0; indiceConvertido < 12 && nome[posicao] != '\0' && nome[posicao] != '\n'; posicao++) {
            if (nome[posicao] != ' ') {
                for (int grupo = 0; grupo < 10; grupo++) {
                    for (int item = 0; grupos[grupo][item] != '\0'; item++) { //verifica se ainda não chegou no fim
                        if (nome[posicao] == grupos[grupo][item]) {
                            convertido[indiceConvertido++] = grupo + '0'; //transformando o número em caractere
                            grupo = 10; //para sair dos dois laços
                            break;
                        }
                    }
                }
            }
        }
        convertido[indiceConvertido] = '\0'; //garante que a *string* finaliza após o último caractere
        printf("%s\n", convertido);
    }
}

//https://pt.stackoverflow.com/q/271549/101
