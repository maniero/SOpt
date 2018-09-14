#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int total1 = 0;
    int total2 = 1001;
    srand(time(NULL));
    for (int i = 1; i < 1001; i++){
        int num = rand() % 1000;
        printf("Numero %d: %d \n ", i, num);
        if (num > total1) total1 = num;
        if (num < total2) total2 = num;
    }
    printf("\n");
    printf("\nO maior numero e: %d\nO menor numero e: %d", total1, total2);
}

//https://pt.stackoverflow.com/q/39371/101
