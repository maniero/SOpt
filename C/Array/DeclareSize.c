#include <stdio.h>

int main() {
    int p[100];
    int z = 0;
    for (int x = 100; x > 1; x--) {
        for (int n = 2; x % n != 0; n++) {
            if (n == x - 1) {
                p[z++] = x;
                break;
            }
        }
    }
    while (z >= 0) printf("%d ", p[z--]);
}

//https://pt.stackoverflow.com/q/344054/101
