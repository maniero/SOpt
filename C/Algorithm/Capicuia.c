#include <stdio.h>

int main() {
    for (int i = 10; i <= 500; i++) {
        int inv = 0, num = i;
        while (num != 0) {
            inv = (inv * 10) + num % 10;
            num /= 10;
        }
        if (i == inv) printf("%d ", i);
    }
}

//https://pt.stackoverflow.com/q/448607/101
