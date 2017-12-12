#include <stdio.h>
int main() {
    int n, n1, arr[250001];
    scanf("%d %d", &n, &n1);
    int max = 0;
    int pos = 0;
    for (int i = 1; i <= n * n1; i++) scanf("%d", &arr[i]);
    for (int i = 1; i <= n; i++) {
        int c = 0;
        for (int j = i; j <= n1 * n; j += n) c += arr[j];
        if (max <= c) {
            max = c;
            pos = i;
        }
    }
    printf("%d", pos);
}

//https://pt.stackoverflow.com/q/257384/101
