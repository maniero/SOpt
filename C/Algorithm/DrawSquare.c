#include<stdio.h>

int main(void) {
    printf("TELL ME THE NUMBER YOU WANT: \n");
    int n;
    scanf("%d", &n);
    for (int row = 0; row < n; row++) {
    	for (int column = 0; column < n; column++) printf("*");
    	printf("\n");
    }
}

//https://pt.stackoverflow.com/q/171183/101
