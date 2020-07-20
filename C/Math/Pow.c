#include <stdio.h>

double power(double n, int p) {
    double pow = 1;
    for (int i = 1; i <= p; i++) pow *= n;
    return pow;
}

int main() {
    printf("%.0f\n", power(5, 2));
    printf("Enter n and p (n^p): ");
    double n;
    int p;
    scanf("%lf", &n);
    scanf("%d", &p);
    printf("The pow is: %.0f\n", power(n, p));
}

//https://pt.stackoverflow.com/q/296497/101
