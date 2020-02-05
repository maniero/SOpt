#include<stdio.h>

int main(){
    int in;
    scanf("%d", &in);
    for (int i = 1; i <= in; i++) {
    	if (i % 4 == 0) printf("PUM\n");
    	else printf("%d ", i);
    } 
}

//https://pt.stackoverflow.com/q/138471/101
