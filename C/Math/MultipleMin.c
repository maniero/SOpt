#include <stdio.h>
#include <stdarg.h>

float multiMin(int num, ...) {
    va_list lista;
    va_start(lista, num);
    float min = va_arg(lista, double);
    for (int i = 1; i < num; i++) {
        float item = va_arg(lista, double);
        if (item < min)
            min = item;
    }
    va_end(lista);
    return min;
}

int main(void) {
    float a, b, c, d;
    scanf("%f\n%f\n%f\n%f\n", &a, &b, &c, &d);
    printf("%f", (a + b + c + d - multiMin(4, a, b, c, d)) / 3);
}

//https://pt.stackoverflow.com/q/57242/101
