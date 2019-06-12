#include <stdlib.h>
#include <stdio.h>
#include <time.h>

void shuffle(int *array, int size) {
    for (int i = size - 1; i > 0; i--) {
        int j = rand() % (i + 1);
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
    }
}

int main() {
    srand(time(NULL));
    int p1 = 0;
    int p2 = 0; 
    int c1[4][4], c2[4][4];
    int numbers[50];
    for (int i = 0; i < 50; i++) numbers[i] = i + 1;
    shuffle(numbers, 50);
    for (int i = 0; i < 4; i++) {
         for (int j = 0; j < 4; j++) {
             c1[i][j] = numbers[i * 4 + j];
             printf("%i\t", c1[i][j]);
         }
         printf("\n");
    }
    printf("\n");
    shuffle(numbers, 50);
    for (int i = 0; i < 4; i++) {
         for (int j = 0; j < 4; j++) {
             c2[i][j] = numbers[i * 4 + j];
             printf("%i\t", c2[i][j]);
         }
         printf("\n");
    }
    printf("\n");
    shuffle(numbers, 50);
    for (int k = 0; k < 50 && (p1 <= 16 || p2 <= 16); k++) {
        int sorteio = numbers[k];
        printf ("%i ", sorteio);
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                if (c1[i][j] == sorteio) p1++;
                if (c2[i][j] == sorteio) p2++;
            }
        }
    }
    if (p1 == 16) printf("\nBingo! Jogador 1 ganhou\n");
    else if (p2 == 16) printf("\nBingo! Jogador 2 ganhou\n");
    else printf("\nempate");
}

//https://pt.stackoverflow.com/q/390787/101
