#include<stdlib.h>
#include<stdio.h>
#include<stdbool.h>
#include <locale.h>
#define true 1
#define false 0
const int limite = 100;

//Definição da estrutura Conjunto como um tipo de variável Conjunto
typedef struct Conjunto {
   int valor;
   short preenchido; //Flag para identificar se o valor do struct foi preenchido
} Conjunto;

/**
Esta função faz a leitura dinâmica de um conjunto de até 100 números inteiros.
*/
void lerConjunto(Conjunto cj[]) {
    char resposta;
    //Limpar o vetor de eventual lixo de memória
    for (int i = 0; i < limite; i++) {
        cj[i].valor = 0;
        cj[i].preenchido = 0;
    }
    int i = 0;
    //Iniciar processo de leitura de valores
    do {
        printf("Insira o %d° valor do conjunto",i);
        scanf("%d", &cj[i].valor);  //Lê o valor
        cj[i].preenchido = true;    //Indica que naquela posição do vetor houve um valor lido
        printf("\n\nDeseja Continuar? Sim, ou Não?");
        scanf("%c", &resposta);
        system("cls"); //Limpa a tela
    } while((resposta == 's' || resposta == 'S') && i < limite);

//    return cj; //Retorna o conjunto lido
}

int main() {
    //Definição de linguagem para aparecer na tela (Acentos e afins)
    setlocale(LC_ALL,"portuguese");
    //Vetor de Struct Conjunto
    Conjunto cj1[100];
    lerConjunto(cj1);
    Conjunto cj2[100];
    lerConjunto(cj2);
    system("PAUSE");
}

//https://pt.stackoverflow.com/q/57607/101
