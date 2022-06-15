#include<stdio.h>

int calculafatorial(int num) {
    int fat = 1;
    while (num > 1) fat *= num--;
    return fat;
}

int main(void) {
    int num;
    scanf("%d", &num);
    printf("%d", calculafatorial(num));
}

//https://pt.stackoverflow.com/q/266565/101
