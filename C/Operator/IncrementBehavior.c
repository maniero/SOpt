#include <stdio.h>

int main(void) {
    int t = 3;
    int p = -5;
    int q = 1;
    int m = (q * p + (t * t) - (t + q)) - 2; 
    int n = (q * p + (t * ++t) - (t + q)) - 2;    
    t = 3;
    int o = (q * p + (t * t++) - (t + q)) - 2;    
    printf("%d, %d, %d", m, n, o);
}

//https://pt.stackoverflow.com/q/334458/101
