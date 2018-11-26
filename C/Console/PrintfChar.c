#include <stdio.h>

int main() {
    int x = 0; int *p = &x;
    float y = 0; float *l = &y;  
    char z = 'B'; char *m = &z;
    printf("O valor de x antes da modificao eh : %d\n", x);
    printf("O valor de y antes da modificao eh : %.2f\n", y);
    printf("O valor de z antes da modificao eh : %c\n", z);
    *p = 70;
    *l = 63.70;
    *m = 'A';
    printf("O valor de x depois da modificao eh : %d\n", x);
    printf("O valor de y depois da modificao eh : %.2f\n", y);
    printf("O valor de z depois da modificao eh : %c\n", z);
}

//https://pt.stackoverflow.com/q/345945/101
