#include<stdio.h>

int main(){
    int in;
    scanf("%d", &in);
    for (int i = 1; i <= in; i += 4) printf("%d %d %d PUM\n", i, i + 1, i + 2);
}

//https://pt.stackoverflow.com/q/138471/101
