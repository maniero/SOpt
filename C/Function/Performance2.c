#include <stdio.h>
#include <time.h>

void minhafuncao() {
    int x = 0;
    x++;
//    return x;
}

int main () {
    clock_t begin, end;
    double time_spent;
    int x;
    begin = clock();
    for (int i = 0; i < 300000000; i++);
    end = clock();
    time_spent = (double)(end - begin) / CLOCKS_PER_SEC;
    printf ("Tempo gasto %.2lf segundos.\n", time_spent);
    begin = clock();
    for (int i = 0; i < 300000000; i++) minhafuncao();
    end = clock();
    time_spent = (double)(end - begin) / CLOCKS_PER_SEC;
    printf ("Tempo gasto %.2lf segundos.\n", time_spent);
    begin = clock();
    for (int i = 0; i < 300000000; i++) x++;
    end = clock();
    time_spent = (double)(end - begin) / CLOCKS_PER_SEC;
    printf ("Tempo gasto %.2lf segundos.\n", time_spent);
    x++;
}
