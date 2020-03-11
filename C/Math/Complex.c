#include <stdio.h>
#include <complex.h>

int main() {
    double x = 1.0;
    double y = 2.0;
    double complex z = x + y * I;
    printf("%.2f %+.2fi\n", creal(z), cimag(z));
}

//https://pt.stackoverflow.com/q/156490/101
