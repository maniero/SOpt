#include <stdio.h>

int max_of_four(int x, int z, int y, int w){
    int max1 = x > z ? x : z;
    int max2 = y > w ? y : w;
    return max1 > max2 ? max1 : max2;
}

int main() {
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    int ans = max_of_four(a, b, c, d);
    printf("%d", ans);
}

//https://pt.stackoverflow.com/q/398525/101
