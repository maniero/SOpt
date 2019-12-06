#include <stdio.h>

int countZeros(int n) {
    int count = 0;
    while (n % 10 == 0) {
        count++;
        n /= 10;
    }
    return count;
}

int main(void) {
    printf("%d\n", countZeros(123000));
    printf("%d\n", countZeros(102030));
}

//https://pt.stackoverflow.com/q/112972/101
