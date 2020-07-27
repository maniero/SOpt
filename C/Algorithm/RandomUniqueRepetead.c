#include <stdio.h>
#include <time.h>
#include <stdlib.h>

void shuffle(int *array, int tamanho) { //sorteia grantidamente único - algoritmo Fisher-Yates
    for (int i = tamanho - 1; i > 0; i--) {
        int j = rand() % (i + 1);
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
    }
}

int main() {
    srand(time(NULL));
    int roll[8] = { 0, 1, 2, 3, 4, 5, 6, 7 }; //cria os valore permitidos
    shuffle(roll, 8); //embaralha
    int resultado[6];
    for (int i = 0; i < 3; i++) { //só escolhe 3 números conforme a definição
        resultado[i] = roll[i];
        resultado[i + 3] = roll[i]; //repete o número
    }
    shuffle(resultado, 6); //embaralha os números que estavam agrupados
    for (int i = 0; i < 6; i++) printf("%d ", resultado[i]);
}

//https://pt.stackoverflow.com/q/315483/101
